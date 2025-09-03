using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
   class Student
{
    //fields
    public string Name { get; set; }
    public string Program { get; set; }

    // Method to display student's basic information (Name + Program)
    public void BasicInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Program: " + Program);
    }
}
// Inherits from Student
class RegularStudent : Student
{
    // Additional property specific to RegularStudent
    public string Section { get; set; }

    // Method to display section where the regular student is enrolled
    public void SectionEnrolled()
    {
        Console.WriteLine("Section: " + Section);
    }
}

// Inherits from Student
class IrregularStudent : Student
{
    // Additional property specific to IrregularStudent
    public int UnitsEnrolled { get; set; }

    // Method to display total units enrolled by the irregular student
    public void EnrolledSemUnits()
    {
        Console.WriteLine("Units Enrolled: " + UnitsEnrolled);
    }
}
}
