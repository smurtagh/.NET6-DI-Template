using System;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Shared;

namespace MyAccessor
{
    public class AccessorServiceProvider : ServiceProviderBase
    {
        public AccessorServiceProvider(IUserContext userContext) : base(userContext)
        {
            serviceCollection.AddScoped<IMyAccessor, MyAccessor>();
        }
    }
}
