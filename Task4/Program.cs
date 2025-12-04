namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 4 Output ===\n");

            // Selection & projection
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var squaredNumbers = numbers.Select(n => n * n).ToList();

            Console.WriteLine("Squared Numbers:");
            foreach (var num in squaredNumbers)
            {
                Console.WriteLine(num);
            }

            // Filter books above 1000
            List<Book> books = new List<Book>
            {
                new Book { Title = "Basic Mathematics", Price = 1200 },
                new Book { Title = "Science Essentials", Price = 900 },
                new Book { Title = "History of Nations", Price = 1500 },
                new Book { Title = "Introduction to Computing", Price = 800 }
            };

            var expensiveBooks = books.Where(b => b.Price > 1000).ToList();

            Console.WriteLine("\nBooks with Price Above 1000:");
            foreach (var book in expensiveBooks)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }

            // Sort students by name
            List<Student> students = new List<Student>
            {
                new Student { Name = "Ram" },
                new Student { Name = "Shyam" },
                new Student { Name = "Hari" },
                new Student { Name = "Shiva" }
            };

            var sortedStudents = students.OrderBy(s => s.Name).ToList();

            Console.WriteLine("\nStudents Sorted Alphabetically:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
