namespace OOPShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(3, 8);

            Console.WriteLine($"Area of the rectangle: {rectangle1.GetArea()}");
        }
    }
}