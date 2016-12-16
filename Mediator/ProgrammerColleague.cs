using System;

namespace Patterns.Mediator
{
	public class ProgrammerColleague : Colleague
	{
		public ProgrammerColleague(ManagerMediator mediator)
			: base(mediator) { }

		public override void Notify(string message)
		{
			Console.WriteLine($"Manager notify Programmer about: \'{message}\'.\n");
		}
	}
}
