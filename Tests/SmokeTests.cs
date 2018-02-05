using System;
using MyManager;
using NUnit.Framework;
using Shared;

namespace Tests
{
    [TestFixture]
    public class SmokeTests
    {
        UserContext UserContext => new UserContext() { UserId = 1 };

        ManagerServiceProvider ManagerServiceProvider => new ManagerServiceProvider(UserContext);

        [Test]
        public void SmokeTests_MyManager()
        {
            var testParam = "test";

            var result = ManagerServiceProvider.GetService<IMyManager>().TestMe("test");

            Assert.AreEqual(result, $"{testParam} : MyManager{UserContext.UserId} : MyEngine{UserContext.UserId} : MyAccessor{UserContext.UserId}");
        }
    }
}
