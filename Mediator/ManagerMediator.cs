using System;

namespace Patterns.Mediator
{
	public class ManagerMediator
	{
		public Colleague Customer { get; private set; }
		public Colleague Programmer { get; private set; }
		public Colleague Tester { get; private set; }

		public ManagerMediator()
		{
			this.Customer = new CustomerColleague(this);
			this.Programmer = new ProgrammerColleague(this);
			this.Tester = new TesterColleague(this);
		}

		public void Send(string message, Colleague colleague)
		{
			if (colleague is CustomerColleague)
			{
				message = $"Customer sent mail to Manager: \'{message}\'.";
				Console.WriteLine(message);
				this.Programmer.Notify(message);
			}
			else if (colleague is ProgrammerColleague)
			{
				message = $"Programmer sent mail to Manager: \'{message}\'.";
				Console.WriteLine(message);
				this.Tester.Notify(message);
			}
			else if (colleague is TesterColleague)
			{
				message = $"Tester sent mail to Manager: \'{message}\'.";
				Console.WriteLine(message);
				this.Customer.Notify(message);
			}
		}
	}
}
