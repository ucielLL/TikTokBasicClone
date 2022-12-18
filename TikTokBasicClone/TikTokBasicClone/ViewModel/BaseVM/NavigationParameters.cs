using System;
using System.Collections.Generic;
using System.Text;

namespace TikTokBasicClone.ViewModel.BaseVM
{
    public class NavigationParameters : Dictionary<string, object>
    {
        public NavigationParameters() { }

        public NavigationParameters(string key, object value)
        {
            Add(key, value);
        }

        public T GetValue<T>(string parameterName)
        {
            try
            {
                return (T)Convert.ChangeType(this[parameterName], typeof(T));
            }
            catch (Exception ex)
            {
                throw new ArgumentOutOfRangeException(parameterName, ex);
            }
        }

    }
}
