using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IServiceBase
    {
        Task<string> TestMe(string value);
    }
}
