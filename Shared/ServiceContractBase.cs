using System;
using System.Threading.Tasks;

namespace Shared
{
    public abstract class ServiceContractBase : IServiceContractBase
    {
        public IUserContext UserContext { get; set; }

        protected ServiceContractBase(IUserContext userContext)
        {
            UserContext = userContext;
        }

        public virtual Task<string> TestMe(string value)
        {
            return Task.FromResult($"{value} : {GetType().Name}{UserContext.UserName}");
        }
    }
}
