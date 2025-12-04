using System;

namespace Task2
{
    internal class Program
    {
        // Delegate for arithmetic operations
        public delegate int Calculate(int num1, int num2);

        public static int Add(int num1, int num2) => num1 + num2;
        public static int Subtract(int num1, int num2) => num1 - num2;

        // Delegate for discount strategies
        public delegate double DiscountStrategy(double price);

        public static double FestivalDiscount(double price) => price * 0.80;
        public static double SeasonalDiscount(double price) => price * 0.90;
        public static double NoDiscount(double price) => price;

        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 2 Output ===\n");

            // Question 1
            Console.WriteLine("---- Question 1 ----");
            Calculate calculateAdd = Add;
            Calculate calculateSubtract = Subtract;

            Console.WriteLine($"Addition (10 + 5): {calculateAdd(10, 5)}");
            Console.WriteLine($"Subtraction (10 - 5): {calculateSubtract(10, 5)}\n");

            // Question 2
            Console.WriteLine("---- Question 2 ----");
            DiscountStrategy festivalDiscount = FestivalDiscount;
            DiscountStrategy seasonalDiscount = SeasonalDiscount;
            DiscountStrategy noDiscount = NoDiscount;

            double price = 1000.0;

            Console.WriteLine($"Original Price: {price}");
            Console.WriteLine($"Festival Discount Price: {festivalDiscount(price)}");
            Console.WriteLine($"Seasonal Discount Price: {seasonalDiscount(price)}");
            Console.WriteLine($"No Discount Price: {noDiscount(price)}\n");

            // Question 2.1 (Lambda)
            Console.WriteLine("---- Question 2.1 ----");
            double finalPrice = CalculateFinalPrice(price, p => p * 0.70);
            Console.WriteLine($"Final Price after 30% Discount (Lambda): {finalPrice}");
        }
    }
}
