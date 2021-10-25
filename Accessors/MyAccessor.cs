using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Shared;

namespace Accessors
{
    internal class MyAccessor : AccessorBase, IMyAccessor
    {
        public MyAccessor(IUserContext userContext, ILogger logger, IConfiguration configuration) : base(userContext, logger, configuration)
        {
        }
    }
}
