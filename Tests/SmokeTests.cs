using System;
using Managers;
using NUnit.Framework;
using Shared;

namespace Tests
{
    [TestFixture]
    public class SmokeTests
    {
        UserContext UserContext => new UserContext() { UserName = "System" };

        ManagerServiceProvider ManagerServiceProvider => new ManagerServiceProvider(UserContext);

        [Test]
        public void SmokeTests_MyManager()
        {
            var testParam = "test";

            var result = ManagerServiceProvider.GetService<IMyManager>().TestMe("test");

            Assert.AreEqual(result, $"{testParam} : MyManager{UserContext.UserName} : MyEngine{UserContext.UserName} : MyAccessor{UserContext.UserName}");
        }
    }
}
