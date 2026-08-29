using Application.Common;
using Application.Contract.ArticleAgg;
using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleCategoryAgg;
using Application.Contract.ArticleCategoryAgg.Commands___DTOs;
using AutoMapper;
using Domain.ArticleCategoryAgg;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ArticleCategoryCategoryAgg
{
    public class ArticleCategoryService : IArticleCategoryService
    {
        private readonly IRepository<ArticleCategory> _repository;
        private readonly IMapper _mapper;

        public ArticleCategoryService(IRepository<ArticleCategory> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateArticleCategoryCommand create, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(create.Title))
                throw new ValidationException("Title is required.");

            if (string.IsNullOrWhiteSpace(create.Content))
                throw new ValidationException("Content is required.");
            var category = new ArticleCategory(create.Title);
            await _repository.AddAsync(category, cancellationToken);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(DeleteArticleCategoryCommand delete, CancellationToken cancellationToken = default)
        {
            if (delete.Id > 0)
            {
                var category = await _repository.GetByIdAsync(delete.Id);
                if (category != null)
                {
                    category.Delete();
                    await _repository.SaveChangesAsync();
                }
            }


        }

        public async Task<IReadOnlyList<ArticleCategoryDTO>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var categories = await _repository.GetAllAsync();
            var filtered = categories.Where(a => !a.IsDeleted).ToList();
            return _mapper.Map<List<ArticleCategoryDTO>>(filtered);
        }

        public async Task<ArticleCategoryDTO> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var category = await _repository.GetByIdAsync(id);

            if (category == null || category.IsDeleted)
                throw new NotFoundException($"ArticleCategory with ID of {id} was not found");

            return _mapper.Map<ArticleCategoryDTO>(category);
        }

        public async Task Update(UpdateArticleCategoryCommand update, CancellationToken cancellationToken = default)
        {
            var category = await _repository.GetByIdAsync(update.Id);
            category.Edit(update.Title);
        }
    }
}
