using BlazorClientMain.Components;
using BlazorClientMain.Components.Dialogs;
using Main.Shared.Api;
using MatBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientMain.Services
{
    public interface INotificationsService
    {
        void HandleError(ApiError error);
    }


    public class NotificationsService : INotificationsService
    {

        private IMatDialogService _dialogService;

        public NotificationsService(IMatDialogService dialogService)
        {
            _dialogService = dialogService;
        }


        public void HandleError(ApiError error)
        {
            var opt = new MatDialogOptions()
            {
                Attributes = new Dictionary<string, object>()
                {
                    { "Title","Error" },
                    { "Message",error.Message },
                    { "Details",error.Details }
                }
            };
            _dialogService.OpenAsync(typeof(NotificationDialog), opt);
        }

    }
}
