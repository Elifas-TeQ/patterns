namespace Patterns.Iterator
{
	public class Book
	{
		public string AuthorName { get; private set; }
		public string Name { get; private set; }
		public int PageCount { get; private set; }

		public Book(string authorName, string name, int pageCount)
		{
			this.AuthorName = authorName;
			this.Name = name;
			this.PageCount = pageCount;
		}
	}
}
