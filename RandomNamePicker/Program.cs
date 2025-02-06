/*
 * Random Name Picker
 * Pawelski
 * 2/5/2025
 * 
 * Instructions:
 * Answer the following questions.
 * 1.   What line of code creates the list named names?
 * 2.   Could we write this program using an array? How would the program look different?
 * 3.   What line of code adds the entered name into the list?
 * 4.   Where does the name get added to the list?
 * 5.   If 5 names are entered, what indexes are valid for the list?
 * 6.   If you don't know how many names are in the list, what code
 *      should you use to find the number of names in the list? How
 *      would you find the last index in this case?
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
