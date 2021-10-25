using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Accessors;
using Engines;
using Managers;
using NUnit.Framework;
using Shared;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public async Task UnitTests_MyManagerMock()
        {
            var receiptEngineMock = new Mock<IMyEngine>();
            receiptEngineMock.Setup(x => x.TestMe(It.IsAny<string>())).Returns((string s) => Task.FromResult($"{s} MOCKED ENGINE"));

            var receiptAccessorMock = new Mock<IMyAccessor>();
            receiptAccessorMock.Setup(x => x.TestMe(It.IsAny<string>())).Returns((string s) => Task.FromResult($"{s} MOCKED ACCESSOR"));

            var myManager = new MyManager(new UserContext() { UserName = "System" });

            myManager.AccessorServiceProvider.OverrideService<IMyAccessor>(receiptAccessorMock.Object);
            myManager.EngineServiceProvider.OverrideService<IMyEngine>(receiptEngineMock.Object);

            var result = await myManager.TestMe("test");

            Assert.IsTrue(result.Contains("MOCKED ENGINE"));
            Assert.IsTrue(result.Contains("MOCKED ACCESSOR"));

            receiptEngineMock.Verify(a => a.TestMe(It.IsAny<string>()), Times.Once());
            receiptAccessorMock.Verify(a => a.TestMe(It.IsAny<string>()), Times.Once());
        }

        [Test]
        public async Task UnitTests_MyManagerFake()
        {
            var myManager = new MyManager(new UserContext() { UserName = "System" });
            myManager.AccessorServiceProvider.OverrideService<IMyAccessor, FakeAccessor>(ServiceLifetime.Scoped);
            myManager.EngineServiceProvider.OverrideService<IMyEngine, FakeEngine>(ServiceLifetime.Scoped);

            var result = await myManager.TestMe("test");

            Assert.IsTrue(result.Contains("FAKE ENGINE"));
            Assert.IsTrue(result.Contains("FAKE ACCESSOR"));
        }

        private class FakeEngine : IMyEngine
        {
            public Task<string> TestMe(string value)
            {
                return Task.FromResult($"{value} FAKE ENGINE");
            }
        }

        private class FakeAccessor : IMyAccessor
        {
            public Task<string> TestMe(string value)
            {
                return Task.FromResult($"{value} FAKE ACCESSOR");
            }
        }
    }
}
