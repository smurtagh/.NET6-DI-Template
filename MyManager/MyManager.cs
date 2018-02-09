using System;
using MyAccessor;
using MyEngine;
using Shared;

namespace MyManager
{
    class MyManager : ManagerBase, IMyManager
    {
        public MyManager(IUserContext userContext) : base(userContext)
        {
        }

        public override string TestMe(string value)
        {
            value = base.TestMe(value);
            value = EngineServiceProvider.GetService<IMyEngine>().TestMe(value);
            value = AccessorServiceProvider.GetService<IMyAccessor>().TestMe(value);
            
            return value;
        }
    }
}
