using System;
using Shared;

namespace Engines
{
    internal class MyEngine : EngineBase, IMyEngine
    {
        public MyEngine(IUserContext userContext) : base(userContext)
        {
        }
    }
}
