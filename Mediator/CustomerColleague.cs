using System;

namespace Patterns.Mediator
{
	public class CustomerColleague : Colleague
	{
		public CustomerColleague(ManagerMediator mediator)
			: base(mediator) { }

		public override void Notify(string message)
		{
			Console.WriteLine($"Manager notify Customer about: \'{message}\'.\n");
		}
	}
}
