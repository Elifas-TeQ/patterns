using System;

namespace Patterns.Observer.Interfaces
{
	public class Program
	{
		public static void Main()
		{
			ObservableObject observable = new ObservableObject();
			ObserverObject observer1 = new ObserverObject(13);
			ObserverObject observer2 = new ObserverObject(722);
			ObserverObject observer3 = new ObserverObject(509);
			observable.AddObserver(observer1);
			observable.AddObserver(observer2);
			observable.AddObserver(observer3);

			observable.NotifyObservers();

			Console.ReadKey();
		}
	}
}
