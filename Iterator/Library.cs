using System;
using System.Collections.Generic;

namespace Patterns.Iterator
{
	public class Library : IBookEnumerable
	{
		private List<Book> books;

		public int Count { get { return this.books.Count; } }

		public Book this[int index] { get { return this.books[index]; } }

		public Library()
		{
			this.books = new List<Book>();
		}

		public IBookEnumerator GetBookEnumerator()
		{
			return new Librarian(this);
		}

		public void AddRangeOfBooks(Book[] books)
		{
			this.books.AddRange(books);
		}
	}
}
