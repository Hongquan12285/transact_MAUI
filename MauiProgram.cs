using CommunityToolkit.Maui;
using DrawnUi.Maui.Draw;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Toolkit.Hosting;
using Telerik.Maui.Controls.Compatibility;

namespace Transact
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder

                .UseMauiApp<App>()
                .UseTelerik()
                .UseMauiCommunityToolkit()
                .ConfigureSyncfusionToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Inter_18pt-Regular.ttf", FontNames.InterRegular);
                    fonts.AddFont("Inter_18pt-Bold.ttf", FontNames.InterBold);
                    fonts.AddFont("Inter_18pt-Italic.ttf", FontNames.InterItalic);
                    fonts.AddFont("Inter_24pt-Medium.ttf", FontNames.InterMedium);
                })
                .ConfigureEssentials(essentials => { essentials.UseVersionTracking(); })
                .RegisterCore()
                .RegisterFeatures()
                .RegisterPages();

#if DEBUG
            builder.Logging.AddDebug();
            builder.Services.AddTransient<MaxCareViewModel>();
            builder.Services.AddTransient<MinSoftwavePage>();
#endif

            return builder.Build();
        }
    }
}