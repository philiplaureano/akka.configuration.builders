using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akka.Configuration.Builders.Hocon
{
    public class HoconBuilder : IHoconBuilder
    {
        private readonly IEnumerable<KeyValuePair<string, string>> _entries;

        public HoconBuilder(IEnumerable<KeyValuePair<string, string>> entries)
        {
            _entries = entries;
        }

        public string GetHocon(string systemName)
        {
            var hoconBuilder = new StringBuilder();

            foreach (var kvp in _entries)
            {
                var currentPair = kvp;
                hoconBuilder.AppendLine($"{currentPair.Key} = {currentPair.Value}");
            }

            return hoconBuilder.ToString();
        }
    }
}
