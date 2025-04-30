namespace YA.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());
            // Ensure Shell is initialized before calling navigation
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (Shell.Current != null)
                {
                    await Shell.Current.GoToAsync("//MainPage");
                }
            });

            return window;
        }
    }
}