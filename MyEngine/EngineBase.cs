using System;
using System.Collections.Generic;
using System.Text;
using MyAccessor;
using Shared;

namespace MyEngine
{
    public class EngineBase : ServiceContractBase
    {
        public AccessorServiceProvider AccessorServiceProvider { get; set; }

        protected EngineBase(IUserContext userContext) : base(userContext)
        {
            AccessorServiceProvider = new AccessorServiceProvider(userContext);
        }
    }
}
