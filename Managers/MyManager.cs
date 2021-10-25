using System;
using System.Threading.Tasks;
using Accessors;
using Engines;
using Shared;

namespace Managers
{
    internal class MyManager : ManagerBase, IMyManager
    {
        public MyManager(IUserContext userContext) : base(userContext)
        {
        }

        public override async Task<string> TestMe(string value)
        {
            value = await base.TestMe(value);
            value = await EngineServiceProvider.GetService<IMyEngine>().TestMe(value);
            value = await AccessorServiceProvider.GetService<IMyAccessor>().TestMe(value);
            
            return value;
        }
    }
}
