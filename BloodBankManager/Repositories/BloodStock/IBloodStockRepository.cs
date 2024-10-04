using BloodBankManager.Models;

public interface IBloodStockRepository
{
    Task<IEnumerable<BloodStock>> GetAllAsync();
    Task<BloodStock> GetByBloodTypeAndRhFactorAsync(string bloodType, string rhFactor);
    Task AddAsync(BloodStock bloodStock);
    Task UpdateAsync(Donation donation);

    Task<List<StockStatus>> GetStatusAsync();
}
