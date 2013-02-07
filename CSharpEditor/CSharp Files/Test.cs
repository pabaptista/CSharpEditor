using System;

namespace Test
{
	public class Program
	{
		public void M1(int i) { }
		public double M2(string s, int i) { return 0; }

		static void Main(string[] args)
		{
			Program p;

			Console.WriteLine("Press ENTER key to start ...");
			Console.ReadLine();
			int c;
			for (c = 0; c <= 100; c++)
			{
				Console.WriteLine(c.ToString());
			}
		}
	}
}





