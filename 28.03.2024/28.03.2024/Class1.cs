using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._03._2024
{
    internal class Class1
    {
        static void Main()
        {


            Student student1 = new Student("Rauf", "Dostuyev", "AB106", 95, true);
            student1.GetInfo();
            student1.CheckGraduation();
            student1.GetDiplomaDegree();

            Console.WriteLine();

            Student student2 = new Student("Sabir", "Guliyev", "AB106", 67, false);
            student2.GetInfo();
            student2.CheckGraduation();
            student2.GetDiplomaDegree();

            Student student3 = new Student("Sahib", "Mammadov", "AB106", 35, true);
            student3.GetInfo();
            student3.CheckGraduation();
            student3.GetDiplomaDegree();

            Student student4 = new Student("Novruzali", "Aliyev", "AB106", 87, false);
            student4.GetInfo();
            student4.CheckGraduation();
            student4.GetDiplomaDegree();

            Student student5 = new Student("Abbasov", "Abbas", "AB106", 99, true);
            student5.GetInfo();
            student5.CheckGraduation();
            student5.GetDiplomaDegree();

            Student student6 = new Student("Shams", "Babayeva", "AB106", 71, true);
            student6.GetInfo();
            student6.CheckGraduation();
            student6.GetDiplomaDegree();
        }
    }
}