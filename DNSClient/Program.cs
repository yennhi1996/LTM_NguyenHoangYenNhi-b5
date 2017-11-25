namespace DNSClient
{
	class Program
	{
		private static dnsclient dnsClient;
		static void Main(string[] args)
		{
			dnsClient = new dnsclient();
			dnsClient.requestResolve("https://google.com");
			System.Console.ReadKey();
		}
	}
}
