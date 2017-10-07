using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// Author: Suman Basyal
    /// Created Date: 10/7/2017
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            HistoryServiceNameSpace.HistoryWebServiceSoapClient client = new HistoryServiceNameSpace.HistoryWebServiceSoapClient();
            Console.WriteLine("Press 1 for adding \n Press 2 for viewing \n");
            int choice;
            Console.WriteLine("Please enter the choice \n");
            choice=Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                //Adding the data
                Console.WriteLine("Enter the month \n");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Enter the day \n");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Enter the events \n");
                string events=Console.ReadLine();
                client.AddToFile(month, day, events);
                Console.WriteLine("added successfully");
            }
            if (choice == 2)
            {
                //viewing the data
                Console.WriteLine("Enter the month \n");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Enter the day \n");
                int day = Convert.ToInt32(Console.ReadLine());
                List<HistoryServiceNameSpace.HistoryPage> list=client.GetFromFile(month, day).ToList();
                foreach (var events in list)
                {
                    Console.WriteLine(events.events);
                    Console.WriteLine("\n");
                }

            }

            Console.ReadLine();
        }
    }
}
