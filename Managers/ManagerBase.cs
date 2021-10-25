using System;
using System.Collections.Generic;
using System.Text;
using Accessors;
using Engines;
using Shared;

namespace Managers
{
    public class ManagerBase : ServiceContractBase
    {
        public AccessorServiceProvider AccessorServiceProvider { get; set; }
        public EngineServiceProvider EngineServiceProvider { get; set; }

        protected ManagerBase(IUserContext userContext) : base(userContext)
        {
            AccessorServiceProvider = new AccessorServiceProvider(userContext);
            EngineServiceProvider = new EngineServiceProvider(userContext);
        }
    }    
}
