using System;

namespace Patterns.Observer.Events
{
	public class Babe
	{
		public event EventHandler<CryingEventArgs> OnNewCrying;

		private void RaiseNewCrying(string reason)
		{
			var handler = OnNewCrying;
			if (handler != null)
			{
				handler(this, new CryingEventArgs { Reason = reason });
			}
		}

		public void IsTooCold()
		{
			this.RaiseNewCrying("TOO COLD");
		}

		public void IsHungry()
		{
			this.RaiseNewCrying("HUNGRY");
		}
	}
}
