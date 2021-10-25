using System;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Shared;

namespace Accessors
{
    public class AccessorServiceProvider : ServiceProviderBase
    {
        public AccessorServiceProvider(IUserContext userContext, ILogger logger, IConfiguration configuration) : base(userContext, logger, configuration)
        {
            serviceCollection.AddScoped<IMyAccessor, MyAccessor>();
        }
    }
}
