using System;

namespace Patterns.TemplateMethod.LocalTemplateMethod
{
	public class Program
	{
		public static void Main()
		{
			FileSaver fileSave = new FileSaver();

			fileSave.SaveStringAsTxtFile("file");
			fileSave.SaveStringAsDllFile("file");

			Console.ReadKey();
		}
	}
}
