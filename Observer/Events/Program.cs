using System;

namespace Patterns.Observer.Events
{
	public class Program
	{
		public static void Main()
		{
			var babe = new Babe();

			babe.OnNewCrying += Cry;

			babe.IsTooCold();
			babe.IsTooCold();

			babe.OnNewCrying += CryLoud;

			babe.IsHungry();
			babe.IsTooCold();

			babe.OnNewCrying -= CryLoud;

			babe.IsHungry();

			Console.ReadKey();
		}

		public static void Cry(object sender, CryingEventArgs e)
		{
			Console.WriteLine($"Babe is crying because of {e.Reason}.");
		}

		public static void CryLoud(object sender, CryingEventArgs e)
		{
			Console.WriteLine($"Babe is crying loudly because of {e.Reason}.");
		}
	}
}
