using System;

namespace Patterns.TemplateMethod
{
	public abstract class EducationEstablishment
	{
		public void Learn()
		{
			this.Enter();
			this.Study();
			this.PassExams();
			this.GetDocuments();
		}

		protected abstract void Enter();

		protected virtual void Study()
		{
			Console.WriteLine("Studying in education establishment...");
		}
	
		protected virtual void PassExams()
		{
			Console.WriteLine("Passing exams in education establishment...\n");
		}
	
		protected virtual void GetDocuments()
		{
			Console.WriteLine("Getting documents in education establishment...\n\n\n");
		}
	}
}
