using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEncapsulation
{
    internal class Shirt
    {
        // Property to store the brand and size of the shirt
        public string Brand {  get; set; }       
        public string Size { get; set; }

        // Method to display the information of the shirt
        public void DisplayInfo()
        {
            Console.WriteLine(); // an empty line for formatting
            // Output the brand and size of the shirt
            Console.WriteLine($"Brand: { Brand }, Size: { Size } ");
            
        }
    }
}
