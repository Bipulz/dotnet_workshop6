namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 5 Output ===\n");

            // Aggregation operation
            List<CashierSales> salesList = new List<CashierSales>
            {
                new CashierSales { CashierName = "Ram", SalesAmount = 1500.0 },
                new CashierSales { CashierName = "Shyam", SalesAmount = 2500.0 },
                new CashierSales { CashierName = "Hari", SalesAmount = 3000.0 },
                new CashierSales { CashierName = "Shiva", SalesAmount = 2000.0 }
            };

            int totalCashiers = salesList.Count;
            double totalSales = salesList.Sum(s => s.SalesAmount);
            double averageSales = salesList.Average(s => s.SalesAmount);
            double maxSales = salesList.Max(s => s.SalesAmount);
            double minSales = salesList.Min(s => s.SalesAmount);

            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Average Sales: {averageSales}");
            Console.WriteLine($"Max Sales: {maxSales}");
            Console.WriteLine($"Min Sales: {minSales}\n");

            // Quantifier operation
            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant { Name = "Ram", Age = 25 },
                new Applicant { Name = "Shyam", Age = 17 },
                new Applicant { Name = "Hari", Age = 30 },
                new Applicant { Name = "Shiva", Age = 15 }
            };

            bool anyUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age >= 16);

            Console.WriteLine($"Any applicant under 18: {anyUnder18}");
            Console.WriteLine($"All applicants above 16: {allAbove16}\n");

            // Element operation
            List<Music> songs = new List<Music>
            {
                new Music { Title = "Kahe Ki Tu Hi How", DurationSeconds = 210 },
                new Music { Title = "Tohore Khatir Jiyali Ham", DurationSeconds = 250 },
                new Music { Title = "Aaisan Kaboo Pahile Bahil Na Rahi Tamanna", DurationSeconds = 300 }
            };

            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstAbove4Min = songs.First(s => s.DurationSeconds > 240);
            var safeLongSong = songs.FirstOrDefault(s => s.DurationSeconds > 600);

            Console.WriteLine($"First Song: {firstSong.Title}, Duration: {firstSong.DurationSeconds} sec");
            Console.WriteLine($"Last Song: {lastSong.Title}, Duration: {lastSong.DurationSeconds} sec");
            Console.WriteLine($"First Song above 4 min: {firstAbove4Min.Title}, Duration: {firstAbove4Min.DurationSeconds} sec");
            Console.WriteLine($"Safe Long Song: {(safeLongSong == null ? "No song found" : safeLongSong.Title)}");
        }
    }
}
