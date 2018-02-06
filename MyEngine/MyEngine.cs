using System;
using Shared;

namespace MyEngine
{
    class MyEngine : EngineBase, IMyEngine
    {
        public MyEngine(IUserContext userContext) : base(userContext)
        {
        }
    }
}
