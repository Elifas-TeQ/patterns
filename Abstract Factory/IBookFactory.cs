namespace patterns.AbstractFactory
{
	public interface IBookFactory
	{
        Copybook GetCopybook();
        Notebook GetNotebook();
	}
}
