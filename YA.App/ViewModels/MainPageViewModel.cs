using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwaitBestPractices.MVVM;
using ThunderDesign.Net.Threading.Collections;
using ThunderDesign.Net.Threading.Extentions;
using YA.App.Models;
using BindableObject = ThunderDesign.Net.Threading.Objects.BindableObject;

namespace YA.App.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        #region constructor
        public MainPageViewModel()
        {
            Tiles = new ObservableCollectionThreadSafe<TileModel>
            {
                new TileModel 
                { 
                    Icon = "dotnet_bot.png", 
                    Title = "Azzed's Page", 
                    Command = new AsyncCommand(async () => await SomePageNavigationAsync().ConfigureAwait(false)) 
                },
                new TileModel
                {
                    Icon = "dotnet_bot.png",
                    Title = "Yusuf's Page",
                    Command = new AsyncCommand(async () => await NavigateAsync("You tapped Settings"))
                },
                new TileModel
                {
                    Icon = "dotnet_bot.png",
                    Title = "Huzaifa's Page",
                    Command = new AsyncCommand(async () => await NavigateAsync("You tapped Profile"))
                },
                new TileModel
                {
                    Icon = "dotnet_bot.png",
                    Title = "Musa's Page",
                    Command = new AsyncCommand(async () => await NavigateAsync("You tapped Help"))
                },
                new TileModel
                {
                    Icon = "dotnet_bot.png",
                    Title = "Yamna's Page",
                    Command = new AsyncCommand(async () => await NavigateAsync("You tapped Help"))
                }
            };
        }
        #endregion

        #region methods
        private async Task SomePageNavigationAsync()
        {
            //Do nothing
        }

        private async Task NavigateAsync(string message)    
        {
            await AppShell.DisplayToastAsync(message);
        }
        #endregion

        #region properties
        public ObservableCollectionThreadSafe<TileModel> Tiles
        {
            get { return this.GetProperty(ref _tiles_Ref); }
            set { this.SetProperty(ref _tiles_Ref, value); }
        }
        #endregion

        #region variables
        private ObservableCollectionThreadSafe<TileModel> _tiles_Ref;
        #endregion
    }
}