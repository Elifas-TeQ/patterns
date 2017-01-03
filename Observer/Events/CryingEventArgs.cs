using System;

namespace Patterns.Observer.Events
{
	public class CryingEventArgs : EventArgs
	{
		public string Reason { get; set; }
	}
}
