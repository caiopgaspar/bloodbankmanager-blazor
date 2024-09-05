using BloodBankManager.Data;
using BloodBankManager.Models;

namespace BloodBankManager.Repositories.BloodStock
{
    public class BloodStockRepository : IBloodStockRepository
    {
        private readonly ApplicationDbContext _context;
        public BloodStockRepository(ApplicationDbContext context)
        {
            _context = context;            
        }

        public async Task AddAsync(Models.BloodStock bloodStock)
        {
            _context.BloodStocks.Add(bloodStock);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var bloodStock = await GetByIdAsync(id);
            _context.BloodStocks.Remove(bloodStock);
        }

        public Task<IEnumerable<Models.BloodStock>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Models.BloodStock> GetByBloodTypeAndRhFactorAsync(string bloodType, string rhFactor)
        {
            throw new NotImplementedException();
        }

        public Task<Models.BloodStock> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Models.BloodStock bloodStock)
        {
            throw new NotImplementedException();
        }
    }
}
