using BloodBankManager.Models;

namespace BloodBankManager.Repositories.Donors
{
    public interface IDonorRepository
    {
        Task AddAsync(Donor donor);
        Task UpdateAsync(Donor donor);
        Task <List<Donor>> GetAllAsync();
        Task DeleteByIdAsync(int id);
        Task<Donor> GetByIdAsync(int id);
    }
}
