using System;
using System.Collections.Generic;
using System.Text;
using Shared;

namespace Accessors
{
    public class AccessorBase : ServiceContractBase
    {
        protected AccessorBase(IUserContext userContext) : base(userContext)
        {

        }
    }
}
