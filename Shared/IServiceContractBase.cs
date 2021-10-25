using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IServiceContractBase
    {
        Task<string> TestMe(string value);
    }
}
