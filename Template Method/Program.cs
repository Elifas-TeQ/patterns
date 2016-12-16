using System;

namespace Patterns.TemplateMethod
{
	public class Program
	{
		public static void Main()
		{
			EducationEstablishment educationEstablishment;

			educationEstablishment = new School();
			educationEstablishment.Learn();

			educationEstablishment = new University();
			educationEstablishment.Learn();

			Console.ReadKey();
		}
	}
}
