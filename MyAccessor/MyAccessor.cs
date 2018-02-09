using System;
using Shared;

namespace MyAccessor
{
    class MyAccessor : AccessorBase, IMyAccessor
    {
        public MyAccessor(IUserContext userContext) : base(userContext)
        {
        }
    }
}
