namespace DNSServer
{
	class Program
	{
		private static named named;
		static void Main(string[] args)
		{
			named = new named();
			while (!false)
			{
				named.startListening();
			}
		}
	}
}
