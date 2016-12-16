namespace Patterns.AbstractFactory
{
    public class Notebook
    {
        public string Size { get; protected set; }
        
        public Notebook(string size)
        {
            this.Size = size;
        }
    }
}
