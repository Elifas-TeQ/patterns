using System;

namespace Patterns.Strategy
{
	public class Program
	{
		public static void Main()
		{
			ISolvable solvable;
			Equation equation;

			solvable = new Differentiation();
			equation = new Equation(solvable);
			equation.RunSolving();

			solvable = new Integration();
			equation = new Equation(solvable);
			equation.RunSolving();
			
			Console.ReadKey();
		}
	}
}
