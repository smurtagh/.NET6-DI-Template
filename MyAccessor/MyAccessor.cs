using System;
using Shared;

namespace MyAccessor
{
    public class MyAccessor : AccessorBase, IMyAccessor
    {
        public MyAccessor(IUserContext userContext) : base(userContext)
        {
        }
    }
}
