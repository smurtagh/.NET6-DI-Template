using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Shared;

namespace Managers
{
    public class ManagerServiceProvider : ServiceProviderBase
    {
        public ManagerServiceProvider(IUserContext userContext, ILogger logger, IConfiguration configuration) : base(userContext, logger, configuration)
        {
            serviceCollection.AddScoped<IMyManager, MyManager>();
        }
    } 
}
