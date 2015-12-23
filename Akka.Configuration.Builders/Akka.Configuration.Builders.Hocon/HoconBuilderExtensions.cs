using System.Collections.Generic;

namespace Akka.Configuration.Builders.Hocon
{
    public static class HoconBuilderExtensions
    {
        public static IHoconBuilder ToHoconBuilder(this IEnumerable<KeyValuePair<string, string>> entries)
        {
            return new HoconBuilder(entries);
        }
    }
}