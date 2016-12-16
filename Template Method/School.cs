using System;

namespace Patterns.TemplateMethod
{
	public class School : EducationEstablishment
	{
		protected override void Enter()
		{
			Console.WriteLine("Entering in school...\n");
		}

		protected override void Study()
		{
			base.Study();
			Console.WriteLine("Studying in school...\n");
		}
	}
}
