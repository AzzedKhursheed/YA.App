/**
 * ##Lesson1.2
 * This is the second class that is run
 * Not much to see here honestly this just makes the app 
 * All comments below are ones from chatgpt
 **/

using Microsoft.Maui; // Required for core MAUI application functionality

namespace YA.App
{
    // The 'App' class is the main entry point for your .NET MAUI application.
    // It inherits from 'Application', which is a base class provided by MAUI
    // that represents your app and its lifecycle (startup, sleep, resume, etc.).
    public partial class App : Application
    {
        // This is the constructor of the App class.
        public App()
        {
            // This method loads and parses the App.xaml file, which usually defines shared resources
            // like styles, colors, or themes. It's auto-generated as part of the XAML compilation.
            InitializeComponent();
        }

        // This method is overridden from the base 'Application' class.
        // It is responsible for creating and returning the main application window.
        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Here, you're creating a new Window and setting its main content to be an instance of AppShell.
            // AppShell is usually a Shell layout that defines your app's navigation structure (tabs, flyouts, etc.).
            var window = new Window(new AppShell());

            // Finally, the created window is returned so MAUI can display it.
            return window;
        }
    }
}