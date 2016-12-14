using System;

namespace patterns.AbstractFactory
{
    public class Program
    {
        public static void Main()
        {
            IBookFactory factory;
            Notebook notebook;
            Copybook copybook;
            
            factory = new CellBookFactory();
            notebook = factory.GetNotebook();
            copybook = factory.GetCopybook();
            
            factory = new LineBookFactory();
            notebook = factory.GetNotebook();
            copybook = factory.GetCopybook();
            
            Console.ReadKey();
        }
    }
}
