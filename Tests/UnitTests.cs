using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MyAccessor;
using MyEngine;
using NUnit.Framework;
using Shared;

namespace Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void UnitTests_MyManagerMock()
        {
            var receiptEngineMock = new Mock<IMyEngine>();
            receiptEngineMock.Setup(x => x.TestMe(It.IsAny<string>())).Returns((string s) => $"{s} FAKE");

            var receiptAccessorMock = new Mock<IMyAccessor>();
            receiptAccessorMock.Setup(x => x.TestMe(It.IsAny<string>())).Returns((string s) => $"{s} NEWS");

            var myManager = new MyManager.MyManager(new UserContext() { UserId = 1 });
            myManager.AccessorServiceProvider.OverrideService<IMyAccessor>(receiptAccessorMock.Object);
            myManager.EngineServiceProvider.OverrideService<IMyEngine>(receiptEngineMock.Object);

            var result = myManager.TestMe("test");

            Assert.IsTrue(result.Contains("FAKE"));
            Assert.IsTrue(result.Contains("NEWS"));

            receiptEngineMock.Verify(a => a.TestMe(It.IsAny<string>()), Times.Once());
            receiptAccessorMock.Verify(a => a.TestMe(It.IsAny<string>()), Times.Once());
        }

        [Test]
        public void UnitTests_MyManagerFake()
        {
            var myManager = new MyManager.MyManager(new UserContext() { UserId = 1 });
            myManager.AccessorServiceProvider.OverrideService<IMyAccessor, FakeAccessor>();
            myManager.EngineServiceProvider.OverrideService<IMyEngine,FakeEngine>();

            var result = myManager.TestMe("test");

            Assert.IsTrue(result.Contains("FAKE"));
            Assert.IsTrue(result.Contains("NEWS"));            
        }

        private class FakeEngine : IMyEngine
        {
            public string TestMe(string value)
            {
                return $"{value} FAKE";
            }
        }

        private class FakeAccessor : IMyAccessor
        {
            public string TestMe(string value)
            {
                return $"{value} NEWS";
            }
        }
    }
}
