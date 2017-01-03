using System;

namespace Patterns.Observer.Delegates
{
	public class Babe
	{
		private readonly Action<string> cry;

		public Babe(Action<string> cry)
		{
			this.cry = cry;
		}

		public void IsTooCold()
		{
			cry("TOO COLD");
		}

		public void IsHungry()
		{
			cry("HUNGRY");
		}
	}
}
