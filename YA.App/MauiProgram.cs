/**
 * ##Lesson1.1
 * This is first class that is run when the application is launched or opened
 * This essentially creates your app and hooks stuff up before the user ever even does anything
 * This will come mostly setup when you create a MauiApp with the Template
 * You hook up your pages here like the mainpage below
**/


// Required namespaces (first 3 are nugets)
// NuGets is the official package manager for .NET.
// A NuGet package is a compiled library that you can
// add to your project, instead of writing that functionality
// from scratch.
using CommunityToolkit.Maui; 
using Microsoft.Extensions.Logging; 
using Syncfusion.Maui.Toolkit.Hosting; 
using YA.App.ViewModels; // This is not a Nuget but gives us access to our ViewModel folder

namespace YA.App
{
    // The MauiProgram.cs file is central to the setup and initialization application.
    // Think of it as the entry point where the configuration of the app is defined.
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            // Create a new MAUI app builder instance
            var builder = MauiApp.CreateBuilder();

            // Set the main app class (App.xaml.cs) as the entry point
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()              // Adds the MAUI Community Toolkit features (e.g., behaviors, converters, UI components)
                .ConfigureSyncfusionToolkit()           // Adds Syncfusion controls to the app (charts, data grids, etc.)
                .ConfigureMauiHandlers(handlers =>
                {
                })

                // Adds custom fonts to your app and assigns aliases for them
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");         // Regular body text
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");       // Emphasis/headers
                    fonts.AddFont("SegoeUI-Semibold.ttf", "SegoeSemibold");          // Optional system font
                    fonts.AddFont("FluentSystemIcons-Regular.ttf", FluentUI.FontFamily); // Icon font
                });

#if DEBUG
            // This enables logging only in debug builds (won't run in production)
            builder.Logging.AddDebug();
            builder.Services.AddLogging(configure => configure.AddDebug());
#endif

            // Register the MainPage and its ViewModel using a helper extension method.
            // This tells Shell to use DI to create the page and ViewModel when navigating to "MainPage".
            builder.Services.AddTransientWithShellRoute<MainPage, MainPageViewModel>("MainPage");

            // Build and return the completed MAUI app
            return builder.Build();
        }
    }
}
