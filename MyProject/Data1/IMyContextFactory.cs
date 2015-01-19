namespace Data1
{
    public interface IMyContextFactory
	{
        IMyContext CreateContext();
        IMyContext CreateContext(string nameOrConnectionString);
	}
}