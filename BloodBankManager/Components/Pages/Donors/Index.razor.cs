using BloodBankManager.Models;
using BloodBankManager.Repositories.Donors;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;

namespace BloodBankManager.Components.Pages.Donors
{
    public class IndexDonorPage : ComponentBase
    {
        [Inject]
        public IDonorRepository repository { get; set; }

        [Inject]
        public IDialogService Dialog { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        public List<Donor> Donors { get; set; } = new();

        public async Task DeleteDonorAsync(Donor donor)
        {
            try
            {
                var result = await Dialog.ShowMessageBox
                (
                    "Atenção",
                    $"Confirm delete the donor {donor.FullName}?",
                    yesText: "YES",
                    cancelText: "NO"
                );

                if (result is true)
                {
                    await repository.DeleteByIdAsync(donor.Id);
                    Snackbar.Add($"Donor {donor.FullName} deleted!", Severity.Success);
                    await OnInitializedAsync();
                }
            }
            catch (Exception ex)
            {
                Snackbar.Add(ex.Message, Severity.Error);
            }
        }

        public bool HideButtons { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> AuthenticationState { get; set; }

        public void GoToUpdate(int id)
        {
            Navigation.NavigateTo($"/donors/update/{id}");
        }

        protected override async Task OnInitializedAsync()
        {
            var auth = await AuthenticationState;

            HideButtons = !auth.User.IsInRole("User");

            Donors = await repository.GetAllAsync();
        }
    }
}
