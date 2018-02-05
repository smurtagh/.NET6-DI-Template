using System;

namespace Shared
{
    public abstract class ServiceContractBase : IServiceContractBase
    {
        public IUserContext UserContext { get; set; }

        protected ServiceContractBase(IUserContext userContext)
        {
            UserContext = userContext;
        }

        public virtual string TestMe(string value)
        {
            return $"{value} : {GetType().Name}{UserContext.UserId}";
        }
    }
}
