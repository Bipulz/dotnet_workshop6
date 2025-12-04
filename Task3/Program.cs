namespace Task3
{
    internal class Program
    {
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (int number in numbers)
            {
                if (condition(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 3 Output ===\n");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 55 };

            Console.WriteLine("Even Numbers:");
            ProcessNumbers(numbers, n => n % 2 == 0);

            Console.WriteLine("\nNumbers Greater Than 10:");
            ProcessNumbers(numbers, n => n > 10);
        }
    }
}
