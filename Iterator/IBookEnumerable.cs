namespace Patterns.Iterator
{
	public interface IBookEnumerable
	{
		IBookEnumerator GetBookEnumerator();
		int Count { get; }
		Book this[int index] { get; }
	}
}
