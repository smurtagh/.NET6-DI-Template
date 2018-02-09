using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Shared
{
    public abstract class ServiceProviderBase
    {
        private ServiceProvider serviceProvider;
        protected IServiceCollection serviceCollection;

        protected ServiceProviderBase(IUserContext userContext)
        {
            // TODO: Santi - please add detailed description of how this is used to pass along the user context
            // TODO: Santi - please add any hyperlinks to examples, blogs, etc that weer references you used
            serviceCollection = new ServiceCollection
            {
                new ServiceDescriptor(typeof(IUserContext), userContext)
            };
        }

        public T GetService<T>() where T : IServiceContractBase
        {
            if (serviceProvider == null)
            {
                serviceProvider = serviceCollection.BuildServiceProvider();
            }

            return serviceProvider.GetService<T>();
        }

        public void OverrideService<T, I>(ServiceLifetime lifetime)
        {
            var service = new ServiceDescriptor(typeof(T), typeof(I), lifetime);
            serviceCollection.Replace(service);

            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        public void OverrideService<T>(T instance)
        {
            var service = new ServiceDescriptor(typeof(T), instance);
            serviceCollection.Replace(service);

            serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
