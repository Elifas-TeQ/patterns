using System;

namespace Patterns.TemplateMethod
{
	public class University : EducationEstablishment
	{
		protected override void Enter()
		{
			Console.WriteLine("Entering in university...\n");
		}

		protected override void Study()
		{
			base.Study();
			Console.WriteLine("Studying in university...");
			this.Practice();
		}

		protected void Practice()
		{
			Console.WriteLine("Practicing in university...\n");
		}

		protected override void GetDocuments()
		{
			Console.WriteLine("Getting documants in university...\n");
		}
	}
}
