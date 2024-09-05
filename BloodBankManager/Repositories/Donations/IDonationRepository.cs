using BloodBankManager.Models;

namespace BloodBankManager.Repositories.Donations
{
    public interface IDonationRepository
    {
        Task AddAsync(Donation donation);
        Task UpdateAsync(Donation donation);
        Task<List<Donation>> GetAllAsync();
        Task DeleteByIdAsync(int id);
        Task<Donation> GetByIdAsync(int id);
    }
}
