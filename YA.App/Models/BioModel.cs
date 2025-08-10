using System.Windows.Input;
using AsyncAwaitBestPractices.MVVM;
using ThunderDesign.Net.Threading.Extentions;
using BindableObject = ThunderDesign.Net.Threading.Objects.BindableObject;

namespace YA.App.Models
{
    public class BioModel : BindableObject
    {
        #region Properties

        public string Name
        {
            get { return this.GetProperty(ref name_Ref); }
            set { this.SetProperty(ref name_Ref, value); }
        }

        public int Age
        {
            get { return this.GetProperty(ref age_Ref); }
            set { this.SetProperty(ref age_Ref, value); }
        }

        public string Bio
        {
            get { return this.GetProperty(ref bio_Ref); }
            set { this.SetProperty(ref bio_Ref, value); }
        }

        public string ProfilePicture
        {
            get { return this.GetProperty(ref profilePicture_Ref); }
            set { this.SetProperty(ref profilePicture_Ref, value); }
        }

        public ICommand EditCommand
        {
            get { return this.GetProperty(ref editCommand_Ref); }
            set { this.SetProperty(ref editCommand_Ref, value); }
        }

        public bool IsEditing
        {
            get => this.GetProperty(ref isEditing_Ref);
            set => this.SetProperty(ref isEditing_Ref, value);
        }

        public ICommand ShowImagePopupCommand
        {
            get { return this.GetProperty(ref showImagePopupCommand_Ref); }
            set { this.SetProperty(ref showImagePopupCommand_Ref, value); }
        }

        public bool IsImagePopupVisible
        {
            get => this.GetProperty(ref isImagePopupVisible_Ref);
            set => this.SetProperty(ref isImagePopupVisible_Ref, value);
        }

        #endregion

        #region Variables

        private string name_Ref;
        private int age_Ref;
        private string bio_Ref;
        private string profilePicture_Ref;
        private ICommand editCommand_Ref;
        private bool isEditing_Ref;
        private ICommand showImagePopupCommand_Ref;
        private bool isImagePopupVisible_Ref;

        #endregion
    }
}
