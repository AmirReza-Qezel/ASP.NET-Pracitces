using Application.Common;
using Application.Contract.ArticleAgg.Commands;
using Application.Contract.ArticleAgg;
using Application.Contract.JournalistAgg.Commands___DTOs;
using AutoMapper;
using Domain.JournalistAgg;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contract.JournalistAgg;

namespace Application.JournalistAgg
{
    public class JournalistService : IJournalistService
    {
        private readonly IJournalistRepository _repository;
        private readonly IMapper _mapper;
        public async Task AddAsync(CreateJournalistCommand create, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(create.FirstName))
                throw new ValidationException("First Name is required.");
            if (string.IsNullOrWhiteSpace(create.LastName))
                throw new ValidationException("Last Name is required.");
            var journalist = new Journalist(create.FirstName,create.LastName,create.ProfilePicturePath);
            await _repository.AddAsync(journalist, cancellationToken);
            await _repository.SaveChangesAsync();
        }

        public async Task Delete(DeleteJournalistCommand delete, CancellationToken cancellationToken = default)
        {
            if (delete.Id > 0)
            {
                var journalist = await _repository.GetByIdAsync(delete.Id);
                if (journalist != null)
                {
                    journalist.Delete();
                    await _repository.SaveChangesAsync();
                }
            }


        }

        public async Task<IReadOnlyList<JournalistDTO>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var journalists = await _repository.GetAllAsync(cancellationToken);
            var filtered = journalists.Where(a => !a.IsDeleted).ToList;
            return _mapper.Map<List<JournalistDTO>>(filtered);
        }

        public async Task<JournalistDTO> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var journalist = await _repository.GetByIdAsync(id);
            if (journalist != null || journalist.IsDeleted)
                throw new NotFoundException($"Journalist with ID of {id} was not found");
            return _mapper.Map<JournalistDTO>(journalist);
        }

        public async Task Update(UpdateJournalistCommand update, CancellationToken cancellationToken = default)
        {
            var journalist = await _repository.GetByIdAsync(update.Id);
            journalist.Edit(update.FirstName,update.LastName);
        }
    }
}
