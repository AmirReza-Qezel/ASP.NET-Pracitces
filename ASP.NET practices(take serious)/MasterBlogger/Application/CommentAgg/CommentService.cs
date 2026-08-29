using Application.Common;
using Application.Contract.CommentAgg.Commands___DTOs;
using Application.Contract.CommentAgg;
using AutoMapper;
using Domain.CommentAgg;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg;
using Domain.Common;

namespace Application.CommentAgg
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _repository;
        private readonly IMapper _mapper;

        public CommentService(IRepository<Comment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateCommentCommand create, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(create.AuthorName))
                throw new ValidationException("Title is required.");

            if (string.IsNullOrWhiteSpace(create.Content))
                throw new ValidationException("Content is required.");
            var comment = new Comment(create.AuthorName, create.Content,create.ArticleId);
            await _repository.AddAsync(comment, cancellationToken);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(DeleteCommentCommand delete, CancellationToken cancellationToken = default)
        {
            if (delete.Id > 0)
            {
                var comment = await _repository.GetByIdAsync(delete.Id);
                if (comment != null)
                {
                    comment.Delete();
                    await _repository.SaveChangesAsync();
                }
            }


        }

        public async Task<IReadOnlyList<CommentDTO>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var comments = await _repository.GetAllAsync(cancellationToken);
            var filtered = comments.Where(a => !a.IsDeleted).ToList;
            return _mapper.Map<List<CommentDTO>>(filtered);
        }

        public async Task<CommentDTO> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var comment = await _repository.GetByIdAsync(id);
            if (comment != null || comment.IsDeleted)
                throw new NotFoundException($"Comment with ID of {id} was not found");
            return _mapper.Map<CommentDTO>(comment);
        }

        public async Task Update(UpdateCommentCommand update, CancellationToken cancellationToken = default)
        {
            var comment = await _repository.GetByIdAsync(update.Id);
            comment.Edit(update.Content);
        }
    }
}
