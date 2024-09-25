using BloodBankManager.Migrations;
using BloodBankManager.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace BloodBankManager.Components.Pages.BloodStocks
{
    public class IndexBloodStockPage : ComponentBase
    {
        [Inject]
        public IBloodStockRepository repository {  get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        public List<BloodStock> BloodStock { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                //BloodStock = new List<BloodStock>
                //{
                //    new BloodStock { BloodAboType = Enums.BloodAboTypeEnum.A, RhFactor = Enums.RhFactorEnum.positive },
                //    new BloodStock { BloodAboType = Enums.BloodAboTypeEnum.A, RhFactor = Enums.RhFactorEnum.negative },
                //    new BloodStock { BloodAboType = Enums.BloodAboTypeEnum.B, RhFactor = Enums.RhFactorEnum.positive },
                //    new BloodStock { BloodAboType = Enums.BloodAboTypeEnum.B, RhFactor = Enums.RhFactorEnum.negative },
                //    new BloodStock { BloodAboType = Enums.BloodAboTypeEnum.AB, RhFactor = Enums.RhFactorEnum.positive },
                //    new BloodStock { BloodAboType = Enums.BloodAboTypeEnum.AB, RhFactor = Enums.RhFactorEnum.negative },
                //    new BloodStock { BloodAboType = Enums.BloodAboTypeEnum.O, RhFactor = Enums.RhFactorEnum.positive },
                //    new BloodStock { BloodAboType = Enums.BloodAboTypeEnum.O, RhFactor = Enums.RhFactorEnum.negative }
                //};

                //UpdateBloodStock();

                BloodStock = (await repository.GetAllAsync()).ToList();
            }
            catch (Exception ex)
            {
                Snackbar.Add("Error loading blood stocks: " + ex.Message, Severity.Error);
            }
        }
    }
}
