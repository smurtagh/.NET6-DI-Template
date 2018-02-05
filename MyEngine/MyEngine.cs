using System;
using Shared;

namespace MyEngine
{
    public class MyEngine : EngineBase, IMyEngine
    {
        public MyEngine(IUserContext userContext) : base(userContext)
        {
        }
    }
}
