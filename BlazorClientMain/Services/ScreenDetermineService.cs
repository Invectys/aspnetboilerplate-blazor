using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientMain.Services
{


    public interface IScreenDetermineService
    {
        EScreen Screen { get; }

        void DetermineScreen();
    }

    public class ScreenDetermineService : IScreenDetermineService
    {
        public EScreen Screen => _screen;

        private EScreen _screen;

        public ScreenDetermineService()
        {
        }

        public void DetermineScreen()
        {
            _screen = EScreen.Medium;
        }
    }

    public enum EScreen
    {
        Small,
        Medium
    }
}
