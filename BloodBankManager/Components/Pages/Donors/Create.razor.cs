using BloodBankManager.Models;
using BloodBankManager.Repositories.Donors;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace BloodBankManager.Components.Pages.Donors
{
    public class CreateDonorPage : ComponentBase
    {
        [Inject]
        public IDonorRepository repository { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        public DonorInputModel InputModel { get; set; } = new();

        public DateTime? DateOfBirth { get; set; } = DateTime.Today;

        public async Task OnValidSubmitAsync(EditContext editContext)
        {
            try
            {
                if (editContext.Model is DonorInputModel model)
                {
                    var donor = new Donor
                    {
                        FullName = model.FullName,
                        Email = model.Email,
                        DateOfBirth = DateOfBirth.Value,
                        Gender = model.Gender,
                        Weight = model.Weight,
                        BloodAboType = model.BloodAboType,
                        RhFactor = model.RhFactor,
                        Observation = model.Observation
                    };

                    await repository.AddAsync(donor);
                    Snackbar.Add("Donor created!", Severity.Success);
                    Navigation.NavigateTo("/donors");
                }
            }
            catch (Exception ex)
            {
                Snackbar.Add(ex.Message, Severity.Error);
            }
        }
    }
}
