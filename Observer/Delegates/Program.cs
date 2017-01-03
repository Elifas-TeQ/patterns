using System;

namespace Patterns.Observer.Delegates
{
	public class Program
	{
		public static void Main()
		{
			var babe = new Babe(Cry);

			babe.IsTooCold();
			babe.IsTooCold();
			babe.IsHungry();
			babe.IsTooCold();
			babe.IsHungry();

			Console.ReadKey();
		}

		public static void Cry(string reason)
		{
			Console.WriteLine($"Babe is crying because of {reason}.");
		}
	}
}
