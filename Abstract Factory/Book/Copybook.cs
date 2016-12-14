namespace patterns.AbstractFactory
{
    public class Copybook
    {
        public int ListCount { get; protected set; }
        public string FrontImage { get; protected set; }
        
        public Copybook(int listCount, string frontImage)
        {
            this.ListCount = listCount;
            this.FrontImage = frontImage;
        }
    }
}
