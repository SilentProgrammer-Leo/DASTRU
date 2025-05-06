using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASTRU_FINALPROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            // Accounts
            Console.ForegroundColor = ConsoleColor.Cyan;
            string[,] account = { { "Admin", "Admin123" },
                              { "Sales", "Sales123" } };

            // Items
            int[] ProductID = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] ProductName = { "iPhone 10", "iPhone 11", "iPhone 12", "iPhone 13", "iPhone 13 PRO MAX", "iPhone 14", "iPhone 14 PRO MAX", "iPhone 15", "iPhone 15 PRO", "iPhone 15 PRO MAX" };
            double[] ProductPrice = { 8999, 9599, 10999, 14999, 16999, 15999, 17999, 16599, 18599, 20999 };

            // Variables
            string username, password;
            bool loop = true;

            while (loop)
            {
                Console.Clear(); // Clear the console at the beginning of each loop
                Console.Write("Enter username: ");
                username = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();

                bool accessGranted = false;
                // Looping through accounts
                int row = account.GetLength(0);
                for (int i = 0; i < row; i++)
                {
                    if (account[i, 0] == username && account[i, 1] == password)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Access Granted!");
                        Console.Read();
                        accessGranted = true;
                        break; // Exit the loop if access is granted
                    }
                }

                if (!accessGranted)
                {
                    Console.WriteLine("Wrong username or password!");
                    Console.WriteLine("Press 'R' to retry or any other key to exit.");
                    char choice = Console.ReadKey().KeyChar;
                    if (char.ToUpper(choice) != 'R')
                    {
                        loop = false; // Exit the loop if the user does not want to retry
                    }
                }
                else
                {
                    // If access is granted, you can proceed to the next part of your application
                    Console.Clear(); // Clear the console before displaying the product list
                    Console.WriteLine("Welcome to the product list!");
                    Console.WriteLine("       =============================================");
                    Console.WriteLine("      |  No. |          Product          |   Price  | ");
                    Console.WriteLine("       =============================================");
                    for (int i = 0; i < ProductID.Length; i++)
                    {
                        Console.WriteLine($"      |  {ProductID[i],2}  |  {ProductName[i]} |  {ProductPrice[i]}");
                    }
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    loop = false; // Exit the loop after displaying the product list
                }
            }

            Console.WriteLine("Exiting the application...");
            Console.Clear();

           
    
}

            //Console.WriteLine("======= INPUT THE PRODUCTS CHOSEN BY THE CUSTOMER/S =======");
            //Console.WriteLine("       =============================================");
            //Console.WriteLine("      | No. |          Product          |   Price   | ");
            //Console.WriteLine("       =============================================");
            //for (int i = 0; i < products.Count; i++)
            //{
            //    Console.WriteLine("      |     |                          |            |");
            //    Console.WriteLine($"      | {i + 1,2}  | {products[i].Name,-24} | PHP {products[i].Price,6:F2} |");
            //    Console.WriteLine("      |     |                          |            |");
            //}
            //Console.WriteLine("       =============================================");
        }
    }


   


