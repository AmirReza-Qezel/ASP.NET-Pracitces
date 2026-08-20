using Application.ArticleAgg;
using Application.Common;
using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg.Commands___DTOs;
using Application.Contract.ArticleCategoryAgg;
using Domain.ArticleAgg;
using Domain.ArticleCategoryAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace MasterBlogger.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleService _articleService;
        private readonly IArticleCategoryService _categoryService;
        public async Task<IActionResult> Index()
        {
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllAsync();
            ViewBag.Categories = new SelectList(categories, nameof(ArticleCategory.Id), nameof(ArticleCategory.Title));

            return View(new CreateArticleCommand());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateArticleCommand article)
        {
            if (!ModelState.IsValid)
            {
                var categories = await _categoryService.GetAllAsync();
                ViewBag.Categories = new SelectList(categories, nameof(ArticleCategory.Id),nameof(ArticleCategory.Title));
                return View(article);
            }

            try
            {
                await _articleService.AddAsync(article);
                TempData["Success"] = "Article created successfully!";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred  while creating the article");
                var categories = await _categoryService.GetAllAsync();
                ViewBag.Categories = new SelectList(categories, nameof(ArticleCategory.Id), nameof(ArticleCategory.Title));
                return View(article);
            }

        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
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
                if (article == null || article.Id <= 0)
                {
                    TempData["ArticleNotFound"] = "No article exists with this information";
                    return RedirectToAction("Index");
                }
                await _articleService.Delete(new DeleteArticleCommand { Id = id });
                TempData["Success"] = "Article was successfully removed";
                return RedirectToAction("Index");
            }
            catch (NotFoundException ex)
            {
                TempData["Error"] = $"An error occurred : {ex.Message.Substring(0, 20)} ...";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"An error occurred : {ex.Message.Substring(0, 20)} ...";
                return RedirectToAction("Index");
            }


        }
    }
}
