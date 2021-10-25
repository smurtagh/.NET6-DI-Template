using System;
using System.Configuration;
using System.Threading.Tasks;
using Managers;
using NUnit.Framework;
using Shared;

namespace Tests
{
    [TestFixture]
    public class SmokeTests
    {
        UserContext _userContext => new UserContext() { UserName = "System" };

        ManagerServiceProvider ManagerServiceProvider => new ManagerServiceProvider(_userContext, null, null);

        [Test]
        public async Task SmokeTests_MyManager()
        {
            var testParam = "test";

            var result = await ManagerServiceProvider.GetService<IMyManager>().TestMe("test");

            Assert.AreEqual(result, $"{testParam} : MyManager{_userContext.UserName} : MyEngine{_userContext.UserName} : MyAccessor{_userContext.UserName}");
        }
    }
}
