namespace Data1
{
	public class MyContextFactory : IMyContextFactory
	{
		private static IMyContextFactory _current = new MyContextFactory();

        private MyContextFactory() { }

        public IMyContext CreateContext()
		{
            return new MyContext();
		}

        public IMyContext CreateContext(string nameOrConnectionString)
		{
            return new MyContext(nameOrConnectionString);
		}

        public static IMyContextFactory Current
		{
			get { return _current; }
			set { _current = value; }
		}

        public static IMyContext Get()
		{
			return Current.CreateContext();
		}

        public static IMyContext Get(string nameOrConnectionString)
		{
			return Current.CreateContext(nameOrConnectionString);
		}
	}
}