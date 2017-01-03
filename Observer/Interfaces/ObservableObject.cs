using System.Collections.Generic;

namespace Patterns.Observer.Interfaces
{
	public class ObservableObject : IObservable
	{
		private List<IObserver> observers;

		public ObservableObject()
		{
			this.observers = new List<IObserver>();
		}

		public void AddObserver(IObserver observer)
		{
			this.observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			this.observers.Remove(observer);
		}

		public void NotifyObservers()
		{
			this.observers.ForEach(x => x.Update());
		}
	}
}
