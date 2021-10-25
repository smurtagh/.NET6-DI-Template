using System;
using System.Collections.Generic;
using System.Text;
using Accessors;
using Shared;

namespace Engines
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
