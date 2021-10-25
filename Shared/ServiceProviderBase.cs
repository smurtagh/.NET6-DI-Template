using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Shared
{
    public abstract class ServiceProviderBase : IServiceProvider
    {
        private ServiceProvider serviceProvider;
        protected ILogger Logger;
        protected IConfiguration Configuration;
        protected IServiceCollection serviceCollection;

        protected ServiceProviderBase(IUserContext userContext, ILogger logger, IConfiguration configuration)
        {
            serviceCollection = new ServiceCollection
            {
                new ServiceDescriptor(typeof(IUserContext), userContext),
                new ServiceDescriptor(typeof(ILogger), logger),
                new ServiceDescriptor(typeof(IConfiguration), configuration),
            };
        }

        public T GetService<T>() where T : IServiceBase
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
