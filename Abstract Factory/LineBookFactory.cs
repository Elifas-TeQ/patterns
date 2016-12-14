namespace patterns.AbstractFactory
{
    public class LineBookFactory : IBookFactory
    {
        public Copybook GetCopybook()
        {
			return new LineCopybook(13, "front-image");
        }
        public Notebook GetNotebook()
        {
			return new LineNotebook("front-image");
        }
    }
}
