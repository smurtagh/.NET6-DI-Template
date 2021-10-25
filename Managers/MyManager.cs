using System;
using System.Threading.Tasks;
using Accessors;
using Engines;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Shared;

namespace Managers
{
    internal class MyManager : ManagerBase, IMyManager
    {
        public MyManager(IUserContext userContext, ILogger logger, IConfiguration configuration) : base(userContext, logger, configuration)
        {
        }

        public override async Task<string> TestMe(string value)
        {
            value = await base.TestMe(value);
            value = await EngineServiceProvider.GetService<IMyEngine>().TestMe(value);
            value = await AccessorServiceProvider.GetService<IMyAccessor>().TestMe(value);
            
            return value;
        }
    }
}
