using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApi.AppCore.IServices
{
    public interface IServices<T>
    {
        T Get(string url);
    }
}
