using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwaitBestPractices.MVVM;
using ThunderDesign.Net.Threading.Extentions;
using BindableObject = ThunderDesign.Net.Threading.Objects.BindableObject;
using System.Windows.Input;

namespace YA.App.Models
{
    public class TileModel : BindableObject
    {
        #region properties
        public string Icon 
        {
            get { return this.GetProperty(ref icon_Ref); }
            set { this.SetProperty(ref icon_Ref, value); }
        }

        public string Title 
        {
            get { return this.GetProperty(ref title_Ref); }
            set { this.SetProperty(ref title_Ref, value); }
        }
        public IAsyncCommand Command 
        {
            get { return this.GetProperty(ref command_Ref); }
            set { this.SetProperty(ref command_Ref, value); }
        }
        #endregion

        #region variables
        string icon_Ref;
        string title_Ref;
        IAsyncCommand command_Ref;
        #endregion

    }
}
