using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingSamples
{

    public class Product
    {
        public Product() { }

        public int DayId { get; set; }
        public int RowId { get; set; }
        public int UserId { get; set; }
        public int ObjectId { get; set; }
        public int Rating { get; set; }
    }

    public class Sales
    {
        public List<Product> Products;
    }

    public class MainCls
    {

        public static void Main(string[] args)
        {

            var salesList = new Sales {Products = new List<Product>()};

            var firstLineInput = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            if (firstLineInput.Length != 3)
            {
                Console.WriteLine("Invalid number of inputs..");
                return;
            }

            var numberOfDays = firstLineInput[0];
            if ((numberOfDays < 1) || (numberOfDays > 100))
            {
                Console.WriteLine("Invalid number of Days..");
                return;
            }
            var numberofUsers = firstLineInput[1];
            if ((numberofUsers < 1) || (numberofUsers > 100))
            {
                Console.WriteLine("Invalid number of Users..");
                return;
            }
            var numberOfObjects = firstLineInput[2];
            if ((numberOfObjects < 1) || (numberOfObjects > 100))
            {
                Console.WriteLine("Invalid number of Objects..");
                return;
            }


            for (var days = 1; days <= numberOfDays; days++)
            {
                var numberOfRows = int.Parse(Console.ReadLine().Trim());
                if ((numberOfRows < 1) || (numberOfRows > 20))
                {
                    Console.WriteLine("Invalid number of Rows..");
                    days--;
                    continue;
                }

                for (var rows = 1; rows <= numberOfRows; rows++)
                {
                    var dataElements = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                    if (dataElements.Length != 3)
                    {
                        Console.WriteLine("Invalid number of inputs for data Elements..");
                        rows--;
                        continue;
                    }

                    var userId = dataElements[0];
                    if ((userId < 1) || (userId > numberofUsers))
                    {
                        Console.WriteLine("Invalid User Id..");
                        rows--;
                        continue;
                    }
                    var objectId = dataElements[1];
                    if ((objectId < 1) || (objectId > numberOfObjects))
                    {
                        Console.WriteLine("Invalid Object Id..");
                        rows--;
                        continue;
                    }
                    var rating = dataElements[2];
                    if ((rating < 0) || (rating > 100))
                    {
                        Console.WriteLine("Invalid Rating..");
                        rows--;
                        continue;
                    }

                    var product = new Product {DayId = days, RowId = rows, UserId = userId, ObjectId = objectId, Rating = rating};
                    salesList.Products.Add(product);
                }
            }

            var highestAverage = salesList.Products.GroupBy(t => new { ObjectId = t.ObjectId })
                .Select(g => new {Average = g.Average(r => r.Rating), ObjectId=g.Key.ObjectId});
            var output = highestAverage.OrderByDescending(r => r.Average).First();

            var numberOfTimes = salesList.Products.GroupBy(t => new { ObjectId = t.ObjectId })
                .Select(g => new { Count = g.Count(), ObjectId = g.Key.ObjectId });
            var output1 = numberOfTimes.OrderByDescending(r => r.Count).First();

            Console.WriteLine($"{output.ObjectId} {output1.ObjectId}");

            //Selection Sort
            SelectionSort.Run();

            //Bubble Sort
            BubbleSort.Run();

            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

    }

}
