namespace Task1
{
    public class Rectangle
    {
        private double length;
        private double breadth;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        public double GetArea() => length * breadth;
        public string ShowDetails() => $"Length: {length}, Breadth: {breadth}";
        public double GetPerimeter() => 2 * (length + breadth);

        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 2;
            rectangle.Breadth = 3;

            Console.WriteLine("---- Rectangle Details ----");
            Console.WriteLine(rectangle.ShowDetails());
            Console.WriteLine($"Area: {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");
            Console.WriteLine("---------------------------");
        }
    }
}
