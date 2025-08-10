using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwaitBestPractices.MVVM;
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
            Bio = new BioModel
            {
                Name = "Yusuf",
                Age = 26,
                Bio = "To be, or not to be: that is the question: Whether 'tis nobler in the mind to suffer The slings and arrows of outrageous fortune, Or to take arms against a sea of troubles And by opposing end them. To die—to sleep, No more; and by a sleep to say we end The heart-ache and the thousand natural shocks That flesh is heir to: 'tis a consummation Devoutly to be wish'd. To die, to sleep; To sleep, perchance to dream—ay, there's the rub: For in that sleep of death what dreams may come When we have shuffled off this mortal coil, Must give us pause—there's the respect That makes calamity of so long life.",
                ProfilePicture = "dotnet_bot.png",
                //IsEditing = true, // force visible Editor
                EditCommand = new AsyncCommand(ToggleEditAsync),
                ShowImagePopupCommand = new AsyncCommand(ToggleImagePopupAsync)
            };
        }
        #endregion

        #region methods

        private async Task NavigateAsync(string message)
        {
            await AppShell.DisplayToastAsync(message);
        }

        private async Task ToggleEditAsync()
        {
            Console.WriteLine($"Toggling IsEditing. Current value: {Bio.IsEditing}");
            Bio.IsEditing = !Bio.IsEditing;

            // Log if the value is toggling
            Console.WriteLine($"New IsEditing value: {Bio.IsEditing}");
            OnPropertyChanged(nameof(Bio));

            if (!Bio.IsEditing)
            {
                await AppShell.DisplayToastAsync("Bio saved");
            }
        }

        private async Task ToggleImagePopupAsync()
        {
            Bio.IsImagePopupVisible = !Bio.IsImagePopupVisible;
            OnPropertyChanged(nameof(Bio));
        }

        #endregion

        #region properties
        //public ObservableCollectionThreadSafe<BioModel> Bio
        //{
        //    get { return this.GetProperty(ref _Bio_Ref); }
        //    set { this.SetProperty(ref _Bio_Ref, value); }
        //}

        public BioModel Bio { get; set; }


        #endregion

        #region variables
        //private ObservableCollectionThreadSafe<BioModel> _Bio_Ref;
        #endregion
    }
}