using BloodBankManager.Models;

public interface IBloodStockRepository
{
    Task<IEnumerable<BloodStock>> GetAllAsync();
    Task<BloodStock> GetByIdAsync(int id);
    Task<BloodStock> GetByBloodTypeAndRhFactorAsync(string bloodType, string rhFactor);
    Task AddAsync(BloodStock bloodStock);
    Task UpdateAsync(BloodStock bloodStock);
    Task DeleteAsync(int id);
}
