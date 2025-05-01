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
    public class YusufHomePageViewModel : BindableObject
    {
        #region constructor
        public YusufHomePageViewModel()
        {
            Bio = new ObservableCollectionThreadSafe<BioModel>
            {
                new BioModel
                {
                    Name = "Yusuf",
                    Age = 26,
                    Bio = "I am a software engineer with a passion for coding and technology.",
                    ProfilePicture = "dotnet_bot.png",
                    EditCommand = new AsyncCommand(async () => await NavigateAsync("You tapped Edit"))
                    },
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
        public ObservableCollectionThreadSafe<BioModel> Bio
        {
            get { return this.GetProperty(ref _Bio_Ref); }
            set { this.SetProperty(ref _Bio_Ref, value); }
        }
        #endregion

        #region variables
        private ObservableCollectionThreadSafe<BioModel> _Bio_Ref;
        #endregion
    }
}