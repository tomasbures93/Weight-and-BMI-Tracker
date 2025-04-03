using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Options;
using BMI.models;
using BMI.Models;

namespace BMI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            string path = Path.Combine(FileSystem.AppDataDirectory, "Database.db");
            builder.Services.AddDbContext<PersonDBContext>(options => 
                                    options.UseSqlite($"Data source={path}"));      // Rework so I have config File 

            builder.Services.AddSingleton<PersonDBContext>();
            builder.Services.AddSingleton(new User("User"));
            builder.Services.AddSingleton<ProfilViewModel>();

            //#if DEBUG
            //            builder.Logging.AddDebug();
            //#endif

            return builder.Build();
        }
    }
}
