using BloodBankManager.Data;
using BloodBankManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManager.Repositories.Donors
{
    public class DonorRepository : IDonorRepository
    {
        private readonly ApplicationDbContext _context;
        public DonorRepository(ApplicationDbContext context)
        {
            _context = context;            
        }
        public async Task AddAsync(Donor donor)
        {
            _context.Donors.Add(donor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var donor = await GetByIdAsync(id);
            _context.Donors.Remove(donor);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Donor>> GetAllAsync()
        {
            return await _context.Donors
                .AsNoTracking().ToListAsync();
        }

        public async Task<Donor> GetByIdAsync(int id)
        {
            return await _context.Donors
                .SingleOrDefaultAsync(d => d.Id == id);
        }

        public async Task UpdateAsync(Donor donor)
        {
            _context.Update(donor);
            await _context.SaveChangesAsync();
        }
    }
}
