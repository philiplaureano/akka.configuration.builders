using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Akka.Configuration.Builders
{
    public class ActorSystemBuilder : IActorSystemBuilder
    {
        private readonly IHoconBuilder _hoconBuilder;
        private readonly IConfigurationFactory _configFactory;

        public ActorSystemBuilder(IHoconBuilder hoconBuilder) : 
            this(hoconBuilder, new DefaultConfigurationFactory())
        {            
        }

        public ActorSystemBuilder(IHoconBuilder hoconBuilder, 
            IConfigurationFactory configFactory)
        {
            _hoconBuilder = hoconBuilder;
            _configFactory = configFactory;
        }

        public ActorSystem Create(string systemName)
        {
            var hocon = _hoconBuilder.GetHocon(systemName);
            var config = _configFactory.ParseString(hocon);

            var actorSystem = ActorSystem.Create(systemName, config);

            return actorSystem;
        }
    }
}
