using System;

namespace Patterns.Iterator
{
	public class Program
	{
		public static void Main()
		{
			var library = new Library();
			library.AddRangeOfBooks(new Book[] {
				new Book("Brown", "Inferno", 341),
				new Book("King", "The Shining", 638),
				new Book("Brown", "Inferno", 341),
				new Book("King", "Mr. Mercedes", 540)
			});

			IBookEnumerator librarian = library.GetBookEnumerator();

			while (librarian.HasNext())
			{
				Book book = librarian.MoveNext();
				Console.WriteLine($"Author: {book.AuthorName}, name: \"{book.Name}\", pages: {book.PageCount}.");
			}

			Console.ReadKey();
		}
	}
}
