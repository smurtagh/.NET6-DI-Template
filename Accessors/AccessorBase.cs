using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Shared;

namespace Accessors
{
    public class AccessorBase : ServiceBase
    {
        protected AccessorBase(IUserContext userContext, ILogger logger, IConfiguration configuration) : base(userContext, logger, configuration)
        {

        }
    }
}
