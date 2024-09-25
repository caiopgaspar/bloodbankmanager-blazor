using BloodBankManager.Data;
using BloodBankManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManager.Repositories.Donations
{
    public class DonationRepository : IDonationRepository
    {
        private readonly ApplicationDbContext _context;
        public DonationRepository(ApplicationDbContext context)
        {
            _context = context;            
        }

        public async Task AddAsync(Donation donation)
        {
            _context.Donations.Add(donation);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var donation = await _context.Donations
                .Include(d => d.Donor)
                .SingleOrDefaultAsync(d => d.Id == id);

            var bloodStock = await _context.BloodStocks
                .SingleOrDefaultAsync(b => b.BloodAboType == donation.Donor.BloodAboType
                                        && b.RhFactor == donation.Donor.RhFactor);

            if (bloodStock != null && bloodStock.QuantityMl >= donation.QuantityMl)
            {
                bloodStock.QuantityMl -= donation.QuantityMl;
                _context.BloodStocks.Update(bloodStock);
            }
            else
            {
                throw new Exception("Blood stock record not found or insufficient quantity to update.");
            }

            _context.Donations.Remove(donation);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Donation>> GetAllAsync()
        {
            return await _context.Donations
                .Include(d => d.Donor)
                .AsNoTracking().ToListAsync();
        }

        public async Task<Donation> GetByIdAsync(int id)
        {
            return await _context.Donations
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Donation donation)
        {
            _context.Update(donation);
            await _context.SaveChangesAsync();
        }
    }
}
