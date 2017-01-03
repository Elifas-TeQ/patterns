using System;

namespace Patterns.Observer.Interfaces
{
	public class ObserverObject : IObserver
	{
		private readonly int id;

		public ObserverObject(int id)
		{
			this.id = id;
		}

		public void Update()
		{
			Console.WriteLine($"Observer #{this.id} was updated due to observable object.");
		}
	}
}
