using BloodBankManager.Data;
using BloodBankManager.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<Models.BloodStock>> GetAllAsync()
        {
            return await _context.BloodStocks.ToListAsync();
        }

        public Task<Models.BloodStock> GetByBloodTypeAndRhFactorAsync(string bloodType, string rhFactor)
        {
            throw new NotImplementedException();
        }


        public async Task UpdateAsync(Donation donation)
        {
            var bloodStock = await _context.BloodStocks
                .SingleOrDefaultAsync(b => b.BloodAboType == donation.Donor.BloodAboType
                                        && b.RhFactor == donation.Donor.RhFactor);

            if (bloodStock != null)
            {
                bloodStock.QuantityMl += donation.QuantityMl;
                _context.BloodStocks.Update(bloodStock);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Blood stock record not found for the given blood Abo type and Rh factor.");             
            }
        }

        public async Task<List<StockStatus>> GetStatusAsync()
        {
            var result = _context.Database.SqlQuery<StockStatus>
                ($"SELECT Id, BloodAboType, RhFactor, QuantityMl AS Quantity, 3000 AS Capacity FROM BloodStock ORDER BY Id;"
                );
            return await Task.FromResult( result.ToList() );
        }//continuar video Gráfico de Barras 10:47
    }
}
