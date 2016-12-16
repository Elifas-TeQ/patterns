using System;

namespace Patterns.Mediator
{
	public class TesterColleague : Colleague
	{
		public TesterColleague(ManagerMediator mediator)
			: base(mediator) { }

		public override void Notify(string message)
		{
			Console.WriteLine($"Manager notify Tester about: \'{message}\'.\n");
		}
	}
}
