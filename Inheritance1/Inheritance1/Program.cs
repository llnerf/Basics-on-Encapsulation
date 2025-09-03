using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            // Display title for Regular Student info
            Console.WriteLine("=== Regular Student Info ===");
            Console.ResetColor();

            // Instantiate Regular Student
            RegularStudent regStud = new RegularStudent();

            // Set values for Regular Student (Name, Program, Section)
            regStud.Name = "Lawrence Langit";
            regStud.Program = "BS Information Technology. ";
            regStud.Section = "IT 301A";

            // Display info
            regStud.BasicInfo();
            regStud.SectionEnrolled();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Irregular Student Info ===");
            Console.ResetColor();

            // Instantiate Irregular Student
            IrregularStudent irregStud = new IrregularStudent();

            // Set values for Regular Student (Name, Program, Section)
            irregStud.Name = "Taboada";
            irregStud.Program = "BS Information Technology";
            irregStud.UnitsEnrolled = 18;

            // Display info
            irregStud.BasicInfo();
            irregStud.EnrolledSemUnits();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            // Display success message
            Console.WriteLine("Program Finished Successfully");
            Console.ResetColor();

            Console.ReadLine(); // Wait for user before closing
        }
    }
}
