using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.CarAgg;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    class CarRepository : ICarRepository
    {
        private readonly AutoGalleryContext _context;

        public CarRepository(AutoGalleryContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Car car)
        {
            await _context.Cars.AddAsync(car);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Cars.AnyAsync(c => c.Id == id);
        }

        public async Task<IReadOnlyList<Car>> GetAllAvailableCarsAsync()
        {
            return await _context.Cars
                .AsNoTracking()
                .Where(c => c.IsActive)
                .ToListAsync();
        }

        public async Task<Car?> GetByIdAsync(int id)
        {
            return await _context.Cars
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public void Remove(Car car)
        {
            car.IsDeleted = true;
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Car car)
        {
            _context.Cars.Update(car);
        }
    }
}
