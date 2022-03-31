using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherAPI.Domain.Interfaces
{
    public interface IModel<T>
    {
        T Get(string url);
    }
}
