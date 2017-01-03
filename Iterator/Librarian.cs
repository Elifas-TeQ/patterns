using System;

namespace Patterns.Iterator
{
	public class Librarian : IBookEnumerator
	{
		private IBookEnumerable library;
		private int Index;

		public Librarian(IBookEnumerable library)
		{
			this.library = library;
			this.Index = -1;
		}

		public bool HasNext()
		{
			return this.Index + 1 < this.library.Count;
		}

		public Book MoveNext()
		{
			this.Index++;
			return this.library[this.Index];
		}

		public void Reset()
		{
			this.Index = -1;
		}
	}
}
