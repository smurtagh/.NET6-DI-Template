using System;
using System.Collections.Generic;
using System.Text;
using Accessors;
using Engines;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Shared;

namespace Managers
{
    public class ManagerBase : ServiceBase
    {
        public AccessorServiceProvider AccessorServiceProvider { get; set; }
        public EngineServiceProvider EngineServiceProvider { get; set; }

        protected ManagerBase(IUserContext userContext, ILogger logger, IConfiguration configuration) : base(userContext, logger, configuration)
        {
            AccessorServiceProvider = new AccessorServiceProvider(userContext, logger, configuration);
            EngineServiceProvider = new EngineServiceProvider(userContext, logger, configuration);
        }
    }    
}