using BloodBankManager.Migrations;
using BloodBankManager.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using System.Globalization;

namespace BloodBankManager.Components.Pages.BloodStocks
{
    public class IndexBloodStockPage : ComponentBase
    {
        [Inject]
        public IBloodStockRepository repository { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        public List<BloodStock> BloodStock { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                BloodStock = (await repository.GetAllAsync()).ToList();
            }
            catch (Exception ex)
            {
                Snackbar.Add("Error loading blood stocks: " + ex.Message, Severity.Error);
            }

            var result = await repository.GetStatusAsync();
            
            if (result is null || !result.Any())
                return;

            XAxisLabels = result
                .Select(x => $"{x.BloodAboType} {x.RhFactor}")
                .ToArray();
            
            //Series = new List<ChartSeries>
            //{
            //    new ChartSeries
            //    {
            //        Name = "Blood Stock",
            //        //Data = result.Select(x => (double)x.Quantity / x.Capacity * 100).ToArray()
            //        Data = result.Select(x => (double)x.Quantity)
            //                     .Concat(new double[] {0, result.Max(x => (double)x.Capacity)})
            //                     .ToArray()                    
            //    }
            //};
            Series = new List<ChartSeries>
            {
                new ChartSeries
                {
                    Name = "Blood Stock",
                    Data = result.Select(x => (double)x.Quantity / x.Capacity * 100)
                                //.Concat(new double[] {0, 100})
                                .ToArray()
                },
                new ChartSeries
                {
                    Data = new double[] {0, 100}  
                }
            };
        }

        public ChartOptions Options = new ChartOptions
        {
            YAxisTicks = 100,
            ShowLegend = false,
            MaxNumYAxisTicks = 10,
            ChartPalette = new []
            {
                Colors.Red.Darken3,
                "transparent"
            }
        };

        public String[] XAxisLabels { get; set; } = Array.Empty<string>();
        public List<ChartSeries> Series { get; set; } = new();
    }
}
