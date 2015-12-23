using System;
using System.Collections.Generic;
using Akka.Configuration.Builders.Hocon;
using NUnit.Framework;

namespace Akka.Configuration.Builders.Tests
{
    [TestFixture]
    public class HoconBuilderTests
    {
        [Test]
        public void Should_be_able_to_convert_string_dictionary_into_hocon()
        {
            IEnumerable<KeyValuePair<string,string>> dictionary = new Dictionary<string, string>()
            {
                {"key1", "value1"},
                {"key2", "value2"}
            };

            var builder = new HoconBuilder(dictionary);
            var hocon = builder.GetHocon("FakeSystem");

            var expectedOutput = @"key1 = value1" + Environment.NewLine +
                "key2 = value2" + Environment.NewLine;

            Assert.AreEqual(expectedOutput, hocon);
        }

        [Test]
        public void Should_be_able_to_convert_dictionary_into_a_hocon_builder()
        {
            IEnumerable<KeyValuePair<string, string>> dictionary = new Dictionary<string, string>()
            {
                {"key1", "value1"},
                {"key2", "value2"}
            };

            var builder = dictionary.ToHoconBuilder();
            var hocon = builder.GetHocon("FakeSystem");

            var expectedOutput = @"key1 = value1" + Environment.NewLine +
                "key2 = value2" + Environment.NewLine;

            Assert.AreEqual(expectedOutput, hocon);
        }
    }
}