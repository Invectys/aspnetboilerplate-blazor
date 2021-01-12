using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiDataMediator
{


    public interface IDataMediator
    {
        Task<T> GetData<T>(string key, bool reload = false, params object[] input);
    }

    public class DataMediator<ApiClient> : IDataMediator
    {

        private Dictionary<string, object> _data = new Dictionary<string, object>();
        private ApiClient _apiClient;
        private Type _apiType;

        public DataMediator(ApiClient api)
        {
            _apiClient = api;
            _apiType = typeof(ApiClient);
        }


        public async Task<T> GetData<T>(string key, bool reload = false,params object[] input)
        {
            bool contains = _data.ContainsKey(key);
            if (contains && !reload)
            {
                return (T)_data[key];
            }
            

            var loaded = await LoadData<T>(key, input);
            _data.Remove(key);
            _data.Add(key, loaded);
            return loaded;
        }

        private Task<T> LoadData<T>(string methodName,params object[] input)
        {
            var loadMethod = _apiType.GetMethod(methodName);
            var loaded = loadMethod.Invoke(_apiClient, input);
            var casted =  (Task<T>)loaded;

            return casted;
        }

    }



}
