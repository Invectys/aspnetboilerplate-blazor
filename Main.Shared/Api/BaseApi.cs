using Main.Shared.Models.Roles;
using Main.Shared.Models.Users;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Main.Shared.Api
{

    public interface IBaseApi
    {
        HttpClient HttpClient { get; }
        Action<ApiError> OnError { get; set; }
        Action<ApiSucces> OnSucces { get; set; }

        Task<ApiOutput<AuthenticationOutput>> Authenticate(AuthenticationInput input);

        //Users
        Task<ApiOutput<ApiArray<UserDto>>> GetAllUsers();
        Task<ApiOutput<ApiArray<UserDto>>> GetUser(ApiIdInput input);
        Task<ApiOutput<UserDto>> CreateUser(CreateUserDto createUser);
        Task<ApiOutput<UserDto>> UpdateUser(UserDto updateUser);
        Task<ApiOutput<ApiNullOutput>> DeleteUser(ApiIdInput<long> input);
        Task<ApiOutput<bool?>> ChangePassword(ChangePasswordDto input);
        Task<ApiOutput<ApiNullOutput>> ResetPassword(ResetPasswordDto input);



        //Roles
        Task<ApiOutput<ApiArray<RoleDto>>> GetAllRoles();
        Task<ApiOutput<ApiArray<RoleDto>>> GetRole(ApiIdInput<int> input);
        Task<ApiOutput<RoleDto>> CreateRole(CreateRoleDto createRole);
        Task<ApiOutput<RoleDto>> UpdateRole(RoleDto updateRole);
        Task<ApiOutput<ApiNullOutput>> DeleteRole(ApiIdInput<int> input);
        Task<ApiOutput<ApiArray<PermissionDto>>> GetAllPermissions();
        


    }


    public class BaseApi : IBaseApi
    {
        public HttpClient HttpClient => _httpClient;

        public bool SimulateApiRequest { get; set; } = false;

        public Action<ApiError> OnError { get; set; }
        public Action<ApiSucces> OnSucces { get; set; }

        private HttpClient _httpClient;
        private HttpCommunicator _httpCommunicator;

        public BaseApi(string baseAddress)
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(baseAddress)
            };
            Init(_httpClient);
        }

        public BaseApi(HttpClient httpClient)
        {
            Init(httpClient);
        }


        public async Task<ApiOutput<AuthenticationOutput>> Authenticate(AuthenticationInput input)
        {

            var output = await _httpCommunicator.ProcessApi<AuthenticationOutput>(
                "api/TokenAuth/Authenticate", HttpMethod.Post, input);

            if (output.Success)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", output.Result.AccessToken);
            }

            return output;
        }


        //Users
        public async Task<ApiOutput<ApiArray<UserDto>>> GetAllUsers()
        {
            return await _httpCommunicator.ProcessApi<ApiArray<UserDto>>(
               "api/services/app/User/GetAll", HttpMethod.Get, null);
        }
        public async Task<ApiOutput<ApiArray<UserDto>>> GetUser(ApiIdInput input)
        {
            return await _httpCommunicator.ProcessApi<ApiArray<UserDto>>(
               "api/services/app/User/Get", HttpMethod.Get, input);
        }
        public async Task<ApiOutput<UserDto>> CreateUser(CreateUserDto createUser)
        {
            return await _httpCommunicator.ProcessApi<UserDto>(
               "api/services/app/User/Create", HttpMethod.Post, createUser, new ApiSucces("User created"));
        }
        public async Task<ApiOutput<UserDto>> UpdateUser(UserDto updateUser)
        {
            return await _httpCommunicator.ProcessApi<UserDto>(
               "api/services/app/User/Update", HttpMethod.Put, updateUser, new ApiSucces("User updated"));
        }
        public async Task<ApiOutput<ApiNullOutput>> DeleteUser(ApiIdInput<long> input)
        {
            return await _httpCommunicator.ProcessApi<ApiNullOutput>(
               "api/services/app/User/Delete", HttpMethod.Delete, input, new ApiSucces("User deleted"));
        }

        public async Task<ApiOutput<bool?>> ChangePassword(ChangePasswordDto input)
        {
            return await _httpCommunicator.ProcessApi<bool?>(
               "api/services/app/User/ChangePassword", HttpMethod.Post, input);
        }
        public async Task<ApiOutput<ApiNullOutput>> ResetPassword(ResetPasswordDto input)
        {
            return await _httpCommunicator.ProcessApi<ApiNullOutput>(
               "api/services/app/User/ResetPassword", HttpMethod.Post, input);
        }


        //Roles
        public async Task<ApiOutput<ApiArray<RoleDto>>> GetAllRoles()
        {
            return await _httpCommunicator.ProcessApi<ApiArray<RoleDto>>(
               "api/services/app/Role/GetAll", HttpMethod.Get, null);
        }
        public async Task<ApiOutput<ApiArray<RoleDto>>> GetRole(ApiIdInput<int> input)
        {
            return await _httpCommunicator.ProcessApi<ApiArray<RoleDto>>(
               "api/services/app/Role/Get", HttpMethod.Get, input);
        }
        public async Task<ApiOutput<RoleDto>> CreateRole(CreateRoleDto createRole)
        {
            return await _httpCommunicator.ProcessApi<RoleDto>(
               "api/services/app/Role/Create", HttpMethod.Post, createRole, new ApiSucces("Role created"));
        }
        public async Task<ApiOutput<RoleDto>> UpdateRole(RoleDto updateRole)
        {
            return await _httpCommunicator.ProcessApi<RoleDto>(
               "api/services/app/Role/Update", HttpMethod.Put, updateRole, new ApiSucces("Role updated"));
        }
        public async Task<ApiOutput<ApiNullOutput>> DeleteRole(ApiIdInput<int> input)
        {
            return await _httpCommunicator.ProcessApi<ApiNullOutput>(
               "api/services/app/Role/Delele", HttpMethod.Delete, input, new ApiSucces("Role deleted"));
        }
        public async Task<ApiOutput<ApiArray<PermissionDto>>> GetAllPermissions()
        {
            return await _httpCommunicator.ProcessApi<ApiArray<PermissionDto>>(
               "api/services/app/Role/GetAllPermissions", HttpMethod.Get, null);
        }



        private void Init(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpCommunicator = new HttpCommunicator(_httpClient, OnError, OnSucces);
        }
    }
}
