using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public interface IServiceProvider
    {
        T GetService<T>() where T : IServiceContractBase;
    }
}
