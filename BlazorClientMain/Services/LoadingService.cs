using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientMain.Services
{
    public interface ILoadingService
    {

        public Action<bool> Changed { get; set; }
        void Show();
        void Hide();

    }

    public class LoadingService : ILoadingService
    {

        private bool _show = false;

        public bool State => _show;

        public Action<bool> Changed { get; set; }

        public void Show()
        {
            _show = true;
            Changed(_show);
        }

        public void Hide()
        {
            _show = false;
            Changed(_show);
        }
    }
}
