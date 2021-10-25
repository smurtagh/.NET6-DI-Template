using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Shared
{
    public abstract class ServiceBase : IServiceBase
    {
        protected IUserContext _userContext;
        protected IConfiguration _configuration;
        protected ILogger _logger;

        protected ServiceBase(IUserContext userContext, ILogger logger, IConfiguration configuration)
        {
            _userContext = userContext;
            _configuration = configuration;
            _logger = logger;
        }

        public virtual Task<string> TestMe(string value)
        {
            return Task.FromResult($"{value} : {GetType().Name}{_userContext.UserName}");
        }
    }
}
