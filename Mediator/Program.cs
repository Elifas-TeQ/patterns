using System;

namespace Patterns.Mediator
{
	public class Program
	{
		public static void Main()
		{
			ManagerMediator manager = new ManagerMediator();

			manager.Customer.Send("New Order");
			manager.Programmer.Send("Work is done");
			manager.Tester.Send("Approved");

			Console.ReadKey();
		}
	}
}
