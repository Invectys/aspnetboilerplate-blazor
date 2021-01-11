using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientMain.Services
{
    public interface ILocalSaver
    {
        T GetValue<T>(string key);
        void SetValue(string key, object value);

    }

    public class LocalSaver : ILocalSaver
    {

        private Dictionary<string, object> _values = new Dictionary<string, object>();

        public LocalSaver()
        {

        }

        public T GetValue<T>(string key)
        {
            if (!_values.ContainsKey(key))
            {
                return default(T);
            }

            var value = _values[key];
            return (T)value;
        }

        public void SetValue(string key, object value)
        {
            _values[key] = value;
        }

    }
}
