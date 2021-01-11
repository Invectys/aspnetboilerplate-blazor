using Main.Shared.Api;
using MatBlazor;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientMain.Services
{

    public interface IErrorSuccesApiHandler
    {
        void RegisterHandler();
        void HandleError(ApiError error);
    }

    public class ErrorSuccesApiHandler : IErrorSuccesApiHandler
    {
        private INotificationsService _notificationsService;
        private IBaseApi _apiClient;
        private IAuthService _authService;
        private IMatToaster _matToaster;
        private ILogger<ErrorSuccesApiHandler> _logger;

        public ErrorSuccesApiHandler(
            IBaseApi apiClient,
            INotificationsService notificationsService,
            IAuthService authService,
            IMatToaster matToaster,
            ILogger<ErrorSuccesApiHandler> logger)
        {
            _apiClient = apiClient;
            _notificationsService = notificationsService;
            _authService = authService;
            _matToaster = matToaster;
            _logger = logger;
        }


        public void RegisterHandler()
        {
            _apiClient.OnError += HandleError;
            _apiClient.OnSucces += HandleSucces;
        }

        public void HandleError(ApiError error)
        {

            if (error.StatusCode == HttpStatusCode.Unauthorized)
            {
                _authService.Logout().Start();
                _logger.LogWarning("LOGOUT because 401 received");
                return;
            }

            _notificationsService.HandleError(error);


        }

        public void HandleSucces(ApiSucces succes)
        {
            if (succes.Show)
            {
                _matToaster.Add(succes.Message, MatToastType.Success);
            }
        }
    }
}
