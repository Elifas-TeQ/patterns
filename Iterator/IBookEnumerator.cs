namespace Patterns.Iterator
{
	public interface IBookEnumerator
	{
		bool HasNext();
		Book MoveNext();
		void Reset();
	}
}
