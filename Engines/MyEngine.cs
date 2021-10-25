using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Shared;

namespace Engines
{
    internal class MyEngine : EngineBase, IMyEngine
    {
        public MyEngine(IUserContext userContext, ILogger logger, IConfiguration configuration) : base(userContext, logger, configuration)
        {
        }
    }
}
