using BloodBankManager.Components.Pages.Donors;
using BloodBankManager.InputModels;
using BloodBankManager.Models;
using BloodBankManager.Repositories.Donations;
using BloodBankManager.Repositories.Donors;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace BloodBankManager.Components.Pages.Donations
{
    public class CreateDonationPage : ComponentBase
    {
        [Inject]
        public IDonationRepository repository { get; set; }

        [Inject]
        public IDonorRepository donorRepository { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        public DonationInputModel InputModel { get; set; } = new();

        public DonorInputModel? DonorInputModel { get; set; }

        public List<Donor> Donors { get; set; } = new List<Donor>();

        public DateTime? DonationDate { get; set; } = DateTime.Today;

        public Donor? SelectedDonor { get; set; }

        protected override async Task OnInitializedAsync()
        {            
            Donors = await donorRepository.GetAllAsync() ?? new List<Donor>();
        }
        public async Task OnValidSubmitAsync(EditContext editContext)
        {
            try
            {
                if (editContext.Model is DonationInputModel model)
                {
                    var donation = new Donation
                    {
                        DonorId = InputModel.SelectedDonor.Id,
                        DonationDate = InputModel.DonationDate,
                        QuantityMl = InputModel.QuantityML
                    };

                    await repository.AddAsync(donation);
                    Snackbar.Add("Donation created successfully!", Severity.Success);
                    Navigation.NavigateTo("/donations");
                }

                
            }
            catch (Exception ex)
            {
                Snackbar.Add(ex.Message, Severity.Error);
            }
        }

        public void OnDonorSelected(int donorId)
        {            
            SelectedDonor = Donors.SingleOrDefault(d => d.Id == donorId);

            if (SelectedDonor != null)
            {
                InputModel.SelectedDonor.Id = SelectedDonor.Id;
            }
        }

        public async Task<IEnumerable<Donor>> SearchDonors(string value, CancellationToken token)
        {
            await Task.Delay(1000, token); //search delay

            if (Donors == null || !Donors.Any())
                return Enumerable.Empty<Donor>();

            if (string.IsNullOrEmpty(value))
                return Donors;

            var filteredDonors = Donors
                .Where(d => d.FullName.Contains(value, StringComparison.InvariantCultureIgnoreCase));                

            return filteredDonors;           
        }
    }
}
