using System;
using Library.CMS.Models;

namespace CMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Content Management System");

            Console.WriteLine("Choose a site to manage: ");

            List<Site> sites = new List<Site>
            {
                new Site{Name = "Site 1"},
            };
            
            int count = 0;
            sites.ForEach(s => Console.WriteLine($"{++count}. {s}"));


            var selection = Console.ReadLine();

            if (!string.IsNullOrEmpty(selection))
            {
                Console.WriteLine(selection);


                var match = sites.FirstOrDefault(s => s?.Name?.Equals(selection, StringComparison.InvariantCultureIgnoreCase)
                ?? false
                );

                if (match != null)
                {
                    Console.WriteLine($"MATCHED: {match}");
                } else
                {
                    Console.WriteLine("No match found");
                }
            }
        }
    }
}
