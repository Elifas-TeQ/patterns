namespace Patterns.Mediator
{
	public abstract class Colleague
	{
		protected ManagerMediator mediator;

		protected Colleague(ManagerMediator mediator)
		{
			this.mediator = mediator;
		}

		public virtual void Send(string message)
		{
			this.mediator.Send(message, this);
		}

		public abstract void Notify(string message);
	}
}
