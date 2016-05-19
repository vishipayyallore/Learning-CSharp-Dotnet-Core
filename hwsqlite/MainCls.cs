using System;
using Microsoft.EntityFrameworkCore;
using static System.Console;

namespace hwsqlite.Sample
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            
            using(var dataStore = new eCommerceDbContext())
            {
                dataStore.Products.Add(
                  new Product { Id=Guid.NewGuid().ToString("N"), Name="Product 1", Price=190.23M, IsAvailable = true}
                );
                var count = dataStore.SaveChanges();
                WriteLine($"{count} records saved to database");
                
                WriteLine("All Products in database:");
                dataStore.Products.ForEachAsync(product => WriteLine($"Id: {product.Id} Name: {product.Name}"));
            }
            
            WriteLine("\nPress any key ...");
            ReadLine();
        }
    }
}
