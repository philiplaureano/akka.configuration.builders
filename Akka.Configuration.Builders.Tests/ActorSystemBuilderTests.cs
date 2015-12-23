using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using NUnit.Framework;

namespace Akka.Configuration.Builders.Tests
{
    [TestFixture]
    public class ActorSystemBuilderTests
    {
        [Test]
        public void Should_create_actor_system_using_given_hoconbuilder_and_config_factory()
        {
            var configFactory = A.Fake<IConfigurationFactory>();
            var hoconBuilder = A.Fake<IHoconBuilder>();
            
            var fakeHocon = "akka.stdout-loglevel = DEBUG";
            var fakeConfig = ConfigurationFactory.ParseString(fakeHocon);
            var systemName = "FakeSystem";

            var builder = new ActorSystemBuilder(hoconBuilder, configFactory);

            A.CallTo(() => configFactory.ParseString(A<string>.Ignored))
                .Returns(fakeConfig);

            A.CallTo(() => hoconBuilder.GetHocon(systemName)).Returns(fakeHocon);

            Assert.IsNotNull(builder.Create(systemName));
        }
    }
}
