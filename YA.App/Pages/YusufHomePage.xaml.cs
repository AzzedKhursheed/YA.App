using YA.App.Models;
using YA.App.ViewModels;

namespace YA.App.Pages
{
    public partial class YusufHomePage : ContentPage
    {
        public YusufHomePage(YusufHomePageViewModel viewModel)
        {
            InitializeComponent();

            //we should be able to remove this because we are using Dependency Injection but its not working
            BindingContext = viewModel;
        }
    }
}