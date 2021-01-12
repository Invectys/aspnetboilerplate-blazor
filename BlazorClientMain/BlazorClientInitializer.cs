using ApiDataMediator;
using BlazorClientMain.Services;
using Blazored.LocalStorage;
using Main.Shared.Api;
using Main.Shared.Models.Roles;
using Main.Shared.Models.Users;
using MatBlazor;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientMain
{
    public static class BlazorClientInitializer
    {

        public static void BuildBlazorMainClient(this WebAssemblyHostBuilder builder)
        {
            //external packages
            builder.Services.AddMatBlazor();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.TopRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
            });


            //Http client
            var client = new HttpClient()
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            };

            builder.Services.AddSingleton(sp => client);
            builder.Services.AddSingleton(typeof(IBaseApi), sp => new BaseApi(client));
            builder.Services.AddSingleton<IDataMediator,DataMediator<IBaseApi>>();

            //Authorization
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, AppAuthenticationStateProvider>();
            builder.Services.AddScoped<IAuthService, AuthService>();


            //App
            builder.Services.AddScoped<INotificationsService, NotificationsService>();
            builder.Services.AddScoped<IErrorSuccesApiHandler, ErrorSuccesApiHandler>();
            builder.Services.AddSingleton<ILocalSaver, LocalSaver>();
            builder.Services.AddSingleton<ILoadingService, LoadingService>();
            builder.Services.AddSingleton<IScreenDetermineService, ScreenDetermineService>();
            builder.Services.AddSingleton<IAppConfiguratorService, AppConfiguratorService>();

        }



        public static async Task Init(this WebAssemblyHost assemblyHost)
        {
            var errorHandler = assemblyHost.Services.GetRequiredService<IErrorSuccesApiHandler>();
            errorHandler.RegisterHandler();


            
        }

    }


    //dummy
    public class FrameworkUI
    {

    }
}
