using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Shared;

namespace Engines
{
    public class EngineServiceProvider : ServiceProviderBase
    {
        public EngineServiceProvider(IUserContext userContext, ILogger logger, IConfiguration configuration) : base(userContext, logger, configuration)
        {
            serviceCollection.AddScoped<IMyEngine, MyEngine>();
        }
    }
}
