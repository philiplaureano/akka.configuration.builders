namespace Akka.Configuration.Builders
{
    internal class DefaultConfigurationFactory : IConfigurationFactory
    {
        public Config ParseString(string hocon)
        {
            return ConfigurationFactory.ParseString(hocon);
        }
    }
}