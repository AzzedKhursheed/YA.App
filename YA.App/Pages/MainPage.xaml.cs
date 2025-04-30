using YA.App.Models;
using YA.App.PageModels;
using YA.App.ViewModels;

namespace YA.App.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}