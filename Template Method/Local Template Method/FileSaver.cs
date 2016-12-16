using System;

namespace Patterns.TemplateMethod.LocalTemplateMethod
{
	public sealed class FileSaver
	{
		public void SaveStringAsTxtFile(string file)
		{
			this.Save(this.ConvertToTxt);
		}

		public void SaveStringAsDllFile(string file)
		{
			this.Save(this.ConvertToDll);
		}

		private void Save(Action converterToAppropriateTypeOfFile)
		{
			Console.WriteLine("Doing some action before converting...");
			converterToAppropriateTypeOfFile();
			Console.WriteLine("Doing some action after converting...\n");
		}

		private void ConvertToTxt()
		{
			Console.WriteLine("Converting to txt...");
		}

		private void ConvertToDll()
		{
			Console.WriteLine("Converting to dll...");
		}
	}
}
