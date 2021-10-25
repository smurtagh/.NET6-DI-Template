using System;
using Shared;

namespace Accessors
{
    internal class MyAccessor : AccessorBase, IMyAccessor
    {
        public MyAccessor(IUserContext userContext) : base(userContext)
        {
        }
    }
}
