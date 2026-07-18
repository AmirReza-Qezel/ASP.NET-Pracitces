using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.CarTypeAgg;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    class CarTypeRepository : ICarTypeRepository
    {
        private readonly AutoGalleryContext _context;

        public CarTypeRepository(AutoGalleryContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CarType carType)
        {
            await _context.CarTypes.AddAsync(carType);
        }

        public async Task<IReadOnlyList<CarType>> GetAllActiveCarTypes()
        {
            return await _context.CarTypes
                .AsNoTracking()
                .Where(ct => ct.IsActive)
                .ToListAsync();
        }

        public async Task<CarType?> GetCarTypeById(int id)
        {
            return await _context.CarTypes
                .FirstOrDefaultAsync(ct => ct.Id == id);
        }

        public async Task<bool> IsCodeUniqueAsync(string code)
        {
            // Returns true if NO other CarType shares this code
            return !await _context.CarTypes.AnyAsync(ct => ct.Code == code);
        }

        public void Remove(CarType carType)
        {
            // Assuming soft-delete pattern is applied here as well:
            carType.IsDeleted = true;
        }

        public void Update(CarType carType)
        {
            _context.CarTypes.Update(carType);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
