using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 6: Travel Summary Report ===\n");

            // List of Tour Bookings
            List<TourBooking> bookings = new List<TourBooking>
            {
                new TourBooking { CustomerName = "Ram",    Destination = "Dubai",      Price = 45000, DurationInDays = 5, IsInternational = true  },
                new TourBooking { CustomerName = "Sita",   Destination = "Pokhara",    Price = 8000,  DurationInDays = 3, IsInternational = false },
                new TourBooking { CustomerName = "Rohan",  Destination = "Bangkok",    Price = 32000, DurationInDays = 6, IsInternational = true  },
                new TourBooking { CustomerName = "Kamal",  Destination = "Chitwan",    Price = 12000, DurationInDays = 5, IsInternational = false },
                new TourBooking { CustomerName = "Shyam",  Destination = "Singapore",  Price = 55000, DurationInDays = 4, IsInternational = true  },
                new TourBooking { CustomerName = "Hari",   Destination = "Lumbini",    Price = 15000, DurationInDays = 2, IsInternational = false }
            };

            // Filtering tours: Price > 10000 and Duration > 4 days
            var filteredTours = bookings
                .Where(t => t.Price > 10000 && t.DurationInDays > 4)
                .ToList();

            // Projecting into TravelSummary
            var projectedTours = filteredTours
                .Select(t => new TravelSummary
                {
                    CustomerName = t.CustomerName,
                    Destination = t.Destination,
                    Category = t.IsInternational ? "International" : "Domestic",
                    Price = t.Price
                })
                .ToList();

            // Sorting: Domestic first, then International, then by Price
            var sortedTours = projectedTours
                .OrderBy(t => t.Category == "International")
                .ThenBy(t => t.Price)
                .ToList();

            // Display results
            foreach (var tour in sortedTours)
            {
                Console.WriteLine($"Customer   : {tour.CustomerName}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Category   : {tour.Category}");
                Console.WriteLine($"Price      : Rs. {tour.Price}\n");
            }
        }
    }
}
