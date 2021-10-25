using System;
using System.Collections.Generic;
using System.Text;
using Accessors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Shared;

namespace Engines
{
    public class EngineBase : ServiceBase
    {
        public AccessorServiceProvider AccessorServiceProvider { get; set; }

        protected EngineBase(IUserContext userContext, ILogger logger, IConfiguration configuration) : base(userContext, logger, configuration)
        {
            AccessorServiceProvider = new AccessorServiceProvider(userContext, logger, configuration);
        }
    }
}
