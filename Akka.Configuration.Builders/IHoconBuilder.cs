namespace Akka.Configuration.Builders
{
    public interface IHoconBuilder
    {
        string GetHocon(string systemName);
    }
}