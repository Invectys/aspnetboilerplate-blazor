using Blazored.LocalStorage;
using Main.Shared.Api;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorClientMain.Services
{
    public interface IAuthService
    {
        Task<ApiOutput<AuthenticationOutput>> Login(AuthenticationInput input);
        Task Logout();
    }

    public class AuthService : IAuthService
    {
        private IBaseApi _apiClient;
        private readonly AppAuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(IBaseApi apiClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _apiClient = apiClient;
            _authenticationStateProvider = (AppAuthenticationStateProvider)authenticationStateProvider;
            _localStorage = localStorage;

        }

        public async Task<ApiOutput<AuthenticationOutput>> Login(AuthenticationInput input)
        {

            var output = await _apiClient.Authenticate(input);

            if (output.Success)
            {
                await _localStorage.SetItemAsync("authToken", output.Result.AccessToken);
                _authenticationStateProvider.MarkUserAsAuthenticated(input.UserNameOrEmailAddress);
            }

            return output;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            _authenticationStateProvider.MarkUserAsLoggedOut();
            _apiClient.HttpClient.DefaultRequestHeaders.Authorization = null;
        }

    }




    public class AppAuthenticationStateProvider : AuthenticationStateProvider
    {
        private HttpClient _httpClient => _apiClient.HttpClient;
        private ILocalStorageService _localStorage;
        private IBaseApi _apiClient;

        public AppAuthenticationStateProvider(
            ILocalStorageService localStorage,
            IBaseApi apiClient)
        {
            _localStorage = localStorage;
            _apiClient = apiClient;
        }

        public void MarkUserAsAuthenticated(string email)
        {
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, email) }, "apiauth"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public void MarkUserAsLoggedOut()
        {
            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(anonymousUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var savedToken = await _localStorage.GetItemAsync<string>("authToken");

            if (string.IsNullOrWhiteSpace(savedToken))
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", savedToken);

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(savedToken), "jwt")));
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                keyValuePairs.Remove(ClaimTypes.Role);
            }

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }


    }


}
