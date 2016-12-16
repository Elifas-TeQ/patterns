namespace Patterns.AbstractFactory
{
	public interface IBookFactory
	{
        Copybook GetCopybook();
        Notebook GetNotebook();
	}
}
