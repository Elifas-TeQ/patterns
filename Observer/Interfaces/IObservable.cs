﻿namespace Patterns.Observer.Interfaces
{
	public interface IObservable
	{
		void AddObserver(IObserver observer);
		void RemoveObserver(IObserver observer);
		void NotifyObservers();
	}
}
