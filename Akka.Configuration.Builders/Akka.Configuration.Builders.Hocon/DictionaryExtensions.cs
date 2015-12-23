using System.Collections.Generic;

namespace Akka.Configuration.Builders.Hocon
{
    public static class DictionaryExtensions
    {
        public static IHoconBuilder ToHoconBuilder(this IEnumerable<KeyValuePair<string, string>> entries)
        {
            return new HoconBuilder(entries);
        }

        public static IActorSystemBuilder CreateActorSystemBuilder(
            this IEnumerable<KeyValuePair<string, string>> entries)
        {
            var hoconBuilder = entries.ToHoconBuilder();
            return new ActorSystemBuilder(hoconBuilder);
        }
    }
}