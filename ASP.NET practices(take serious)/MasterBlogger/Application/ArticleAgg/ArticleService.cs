using Application.Common;
using Application.Contract.ArticleAgg;
using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg.Commands___DTOs;
using AutoMapper;
using Domain.ArticleAgg;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ArticleAgg
{
    public class ArticleService : IArticleService
    {
        private readonly IRepository<Article> _repository;
        private readonly IMapper _mapper;

        public ArticleService(IRepository<Article> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateArticleCommand create, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(create.Title))
                throw new ValidationException("Title is required.");

            if (string.IsNullOrWhiteSpace(create.Content))
                throw new ValidationException("Content is required.");
            var article = new Article(create.Title, create.Content, create.ArticleCategoryId);
            await _repository.AddAsync(article,cancellationToken);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(DeleteArticleCommand delete, CancellationToken cancellationToken = default)
        {
            if (delete.Id > 0)
            {
               var article = await _repository.GetByIdAsync(delete.Id);
                if (article != null)
                {
                    article.Delete();
                    await _repository.SaveChangesAsync();
                }
            }
                
                
        }

        public async Task<IReadOnlyList<ArticleDTO>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var articles = await _repository.GetAllAsync(cancellationToken);
            var filtered = articles.Where(a => !a.IsDeleted).ToList();
            return _mapper.Map<List<ArticleDTO>>(filtered);
        }

        public async Task<ArticleDTO> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var article = await _repository.GetByIdAsync(id);
            if (article == null || article.IsDeleted)
                throw new NotFoundException($"Article with ID of {id} was not found or either is deleted");
            return _mapper.Map<ArticleDTO>(article);
        }

        public async Task Update(UpdateArticleCommand update, CancellationToken cancellationToken = default)
        {
            var article = await _repository.GetByIdAsync(update.Id);
            if (article == null || article.IsDeleted)
                throw new NotFoundException($"Article with ID of {update.Id} was not found or either is deleted");
                article.Edit(update.Title, update.Content, update.ArticleCategoryId);
            await _repository.SaveChangesAsync();
        }
    }
}
