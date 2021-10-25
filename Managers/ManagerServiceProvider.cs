using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Shared;

namespace Managers
{
    public class ManagerServiceProvider : ServiceProviderBase
    {
        public ManagerServiceProvider(IUserContext userContext) : base(userContext)
        {
            serviceCollection.AddScoped<IMyManager, MyManager>();
        }
    } 
}
