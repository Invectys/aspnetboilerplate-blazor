using MatBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientMain.Services
{


    public interface IAppConfiguratorService
    {
        string AppName { get; set; }
        MatTheme Theme { get; set; }
    }

    public class AppConfiguratorService : IAppConfiguratorService
    {
        public string AppName { get; set; }
        public MatTheme Theme { get; set; }

        public AppConfiguratorService()
        {
            AppName = "Tusa";
            Theme = new MatTheme()
            {
                Primary = MatThemeColors.Blue._700.Value,
                Secondary = MatThemeColors.Amber._700.Value
            };
        }



    }
}
