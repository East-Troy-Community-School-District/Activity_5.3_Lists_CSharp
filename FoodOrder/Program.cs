/*
 * Food Order
 * Pawelski
 * 2/5/2025
 * 
 * Instructions:
 * 1.   Add a breakpoint to line  and run the program in debugging mode.
 *      Try entering a variety of inputs and step through the program to
 *      see how it works.
 * 2.   This program uses parallel lists. What are parallel lists?
 * 3.   What does this line of code do?
 *      items.Add(Console.ReadLine().ToLower());
 * 
 * 4.   What does this line of code do?
 *      if (items.Contains(item))
 * 
 * 5.   What does these lines of code do?
 *      int index = items.IndexOf(item);
        items.Remove(item);
        prices.RemoveAt(index);
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            List<double> prices = new List<double>();

            while (true)
            {
                int option;
                Console.WriteLine("Here are the actions you can perform:");
                Console.WriteLine("1. Add an item to your food order.");
                Console.WriteLine("2. Remove an item to your food order.");
                Console.WriteLine("3. View your food order.");
                Console.WriteLine("4. Complete your food order.");
                Console.Write("What would you like to do? (1-4) >> ");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    option = -1;
                }

                if (option == 1)
                {
                    AddItem(items, prices);
                }
                else if (option == 2)
                {
                    RemoveItem(items, prices);
                }
                else if (option == 3)
                {
                    ViewOrder(items, prices);
                }
                else if (option == 4)
                {
                    ViewOrder(items, prices);
                    double orderSubTotal = CalculateTotal(prices);
                    double tax = CalculateTax(orderSubTotal);
                    double orderTotal = orderSubTotal + tax;
                    Console.WriteLine("Subtotal: " + orderSubTotal.ToString("C"));
                    Console.WriteLine("Tax: " + tax.ToString("C"));
                    Console.WriteLine("Total: " + orderTotal.ToString("C"));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Gets an item and price from the user. Adds it to the appropriate
        /// list.
        /// </summary>
        /// <param name="items">List of items in the order.</param>
        /// <param name="prices">List of prices of items in order.</param>
        private static void AddItem(List<string> items, List<double> prices)
        {
            Console.Write("Enter the name of the item you would like to add to the order. >> ");
            items.Add(Console.ReadLine().ToLower());
            Console.Write("What is the price of the item? >> ");
            prices.Add(Convert.ToDouble(Console.ReadLine()));
        }

        /// <summary>
        /// Gets an item from the user. Removes the item from the
        /// order, if it exists.
        /// </summary>
        /// <param name="items">List of items in the order.</param>
        /// <param name="prices">List of prices of items in order.</param>
        private static void RemoveItem(List<string> items, List<double> prices)
        {
            string item;
            Console.Write("Enter the name of the item you would like to remove from the order. >> ");
            item = Console.ReadLine().ToLower();
            if (items.Contains(item))
            {
                int index = items.IndexOf(item);
                items.Remove(item);
                prices.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("That item does not exist!");
            }
        }

        /// <summary>
        /// Displays the order to the console.
        /// </summary>
        /// <param name="items">List of items in the order.</param>
        /// <param name="prices">List of prices of items in order.</param>
        private static void ViewOrder(List<string> items, List<double> prices)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i] + " - " + prices[i].ToString("C"));
            }
        }

        /// <summary>
        /// Calculates the total of the values in the list.
        /// </summary>
        /// <param name="list">A list of doubles.</param>
        /// <returns>Total of the doubles in the list.</returns>
        private static double CalculateTotal(List<double> list)
        {
            double total = 0;
            foreach (double price in list)
            {
                total += price;
            }
            return total;
        }

        /// <summary>
        /// Calculates the tax to be collected. Specific to WI.
        /// </summary>
        /// <param name="price">Price of an item.</param>
        /// <returns>The tax to be collected.</returns>
        private static double CalculateTax(double price)
        {
            const double WI_SALES_TAX = 0.05;
            return WI_SALES_TAX * price;
        }
    }
}
