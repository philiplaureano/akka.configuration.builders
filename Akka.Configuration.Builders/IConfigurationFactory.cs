namespace Akka.Configuration.Builders
{
    public interface IConfigurationFactory
    {
        Config ParseString(string hocon);
    }
}