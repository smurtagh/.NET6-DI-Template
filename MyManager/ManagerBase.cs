using System;
using System.Collections.Generic;
using System.Text;
using MyAccessor;
using MyEngine;
using Shared;

namespace MyManager
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
