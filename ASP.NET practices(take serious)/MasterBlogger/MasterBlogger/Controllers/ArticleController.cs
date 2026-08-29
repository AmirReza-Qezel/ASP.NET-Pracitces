using Application.ArticleAgg;
using Application.Common;
using Application.Contract.ArticleAgg;
using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg.Commands___DTOs;
using Application.Contract.ArticleCategoryAgg;
using Domain.ArticleAgg;
using Domain.ArticleCategoryAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;

namespace MasterBlogger.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IArticleCategoryService _categoryService;
        private readonly IMapper _mapper;

        public ArticleController(IArticleService articleService, IArticleCategoryService categoryService, IMapper mapper)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await LoadCategoryDropdown();

            return View(new CreateArticleCommand());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateArticleCommand article)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    await LoadCategoryDropdown();
                    await _articleService.AddAsync(article);
                    TempData["Success"] = "Article created successfully!";
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    TempData["Error"] = $"An error occurred : {ex.Message}";
                }
            }
            await LoadCategoryDropdown();
            return View(article);

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
                    var article = await _articleService.GetByIdAsync(id);
                    var updateCommand = _mapper.Map<UpdateArticleCommand>(article);
                    await LoadCategoryDropdown(id);
                    return View(updateCommand);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateArticleCommand update)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _articleService.Update(update);
                    TempData["Success"] = "Article Added Successfully";
                    return RedirectToAction("Index", "Home");
                }
                catch (NotFoundException)
                {
                    TempData["Error"] = "Article not found";

                }
                catch (Exception)
                {
                    TempData["Error"] = "An error occurred  while creating the article";

                }
            }
            await LoadCategoryDropdown(update.Id);
            return View(update);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var article = await _articleService.GetByIdAsync(id);
            return View(article);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, bool confirm = true)
        {
            try
            {
                var article = await _articleService.GetByIdAsync(id);
                await _articleService.Delete(new DeleteArticleCommand { Id = id });
                TempData["Success"] = "Article was successfully removed";
                return RedirectToAction("Index");
            }
            catch (NotFoundException nfex)
            {
                TempData["Error"] = "Article not found";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "An error occurred  while creating the article";
                return RedirectToAction("Index");
            }

        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var article = await _articleService.GetByIdAsync(id);
                return View(article);
            }
            catch (NotFoundException nfex)
            {
                TempData["Error"] = "Article not found";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "An error occurred  while creating the article";
                return RedirectToAction("Index");
            }

        }
        private async Task LoadCategoryDropdown(int? selectedId = null)
        {
            // Load categories from service
            var categories = await _categoryService.GetAllAsync();
            ViewBag.Categories = new SelectList(categories, "Id", "Title",selectedId);
        }

    }
}
