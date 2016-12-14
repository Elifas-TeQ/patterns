namespace patterns.AbstractFactory
{
	public class CellBookFactory : IBookFactory
	{
        public Copybook GetCopybook()
        {
			return new CellCopybook(13, "front-image");
        }
        public Notebook GetNotebook()
        {
			return new CellNotebook("front-image");
        }
	}
}
