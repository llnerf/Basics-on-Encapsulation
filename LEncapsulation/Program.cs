using LEncapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langit_EncapsulationUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter the brand and size  of the shirt
            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter Size: ");
            string size = Console.ReadLine();

            // Create a new instance of the Shirt class
            Shirt shirt1 = new Shirt();

            // Assign the user input to the Shirt's Brand  and size property
            shirt1.Brand = brand;
            shirt1.Size = size;

            // Call the method to display the shirt's information
            shirt1.DisplayInfo();
            Console.ReadLine();

        }
    }
}
