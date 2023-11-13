/*
 * Random Name Picker
 * Pawelski
 * 11/13/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * What line of code creates the list named names?
 * Could we write this program using an array? How would
 * the program look different?
 * What line of code adds the entered name into the list?
 * Where does the name get added to the list?
 * If 5 names are entered, what indexes are valid for the list?
 * If you don't know how many names are in the list, what code
 * should you use to find the number of names in the list? How
 * would you find the last index in this case?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNamePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            string name;
            Console.Write("Enter a name you would like to add to the list. >> ");
            name = Console.ReadLine();
            do
            {
                names.Add(name);
                Console.Write("Enter another name you would like to add to the list. (zzzzz to stop) >> ");
                name = Console.ReadLine().ToLower();
            } while (name != "zzzzz");
            Console.WriteLine();

            Random generator = new Random();
            int index = generator.Next(0, names.Count);
            Console.WriteLine(names[index]);
        }
    }
}
