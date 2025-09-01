using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegularStudent student = new RegularStudent();
            
            student.Name = "Lawrence";
            student.Program = "BSIT";
            student.Section = "IT301A";
            student.BasicInfo();
            student.SectionEnrolled();

            IrregularStudent student1 = new IrregularStudent();
          
            student1.Name = "Taboada";
            student1.Program = "BSIT";
            student1.Unit = 18;
            student1.BasicInfo();
            student1.EnrolledSemUnits();


            Console.ReadKey();
        }
    }
}
