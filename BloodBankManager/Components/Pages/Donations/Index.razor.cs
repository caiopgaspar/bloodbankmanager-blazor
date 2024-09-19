using BloodBankManager.Models;
using BloodBankManager.Repositories.Donations;
using BloodBankManager.Repositories.Donors;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BloodBankManager.Components.Pages.Donations
{
    public class IndexDonationPage : ComponentBase
    {
        [Inject]
        public IDonationRepository repository { get; set; }

        [Inject]
        public IDialogService Dialog { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        public List<Donation> Donations { get; set; } = new();

        public async Task DeleteDonationAsync(Donation donation)
        {
            try
            {
                var result = await Dialog.ShowMessageBox
                (
                    "Atenção",
                    $"Confirm delete the donor {donation.Donor.FullName}?",
                    yesText: "YES",
                    cancelText: "NO"
                );

                if (result is true)
                {
                    await repository.DeleteByIdAsync(donation.Id);
                    Snackbar.Add($"Donor {donation.Donor.FullName} deleted!", Severity.Success);
                    await OnInitializedAsync();
                }
            }
            catch (Exception ex)
            {
                Snackbar.Add(ex.Message, Severity.Error);
            }
        }

        public void GoToUpdate(int id)
        {
            Navigation.NavigateTo($"/donations/update/{id}");
        }

        protected override async Task OnInitializedAsync()
        {
            Donations = await repository.GetAllAsync();
        }
    }
}
