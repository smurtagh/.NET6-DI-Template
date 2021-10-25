using Microsoft.AspNetCore.Mvc;
using Shared;
using IServiceProvider = Shared.IServiceProvider;

namespace MyAPIClient.Controllers
{
    public class ControllerBase<T> : ControllerBase
    {
        protected readonly ILogger<T> _logger;
        protected readonly IServiceProvider _serviceProvider;
        protected readonly IUserContext _userContext;

        public ControllerBase(ILogger<T> logger, IServiceProvider serviceProvider, IUserContext userContext)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
            _userContext = userContext;
        }
    }
}