namespace Patterns.Strategy
{
	public class Equation
	{
		public ISolvable Solvable { get; set; }

		public Equation(ISolvable solvable)
		{
			this.Solvable = solvable;
		}

		public void RunSolving()
		{
			this.Solvable.Solve();
		}
	}
}
