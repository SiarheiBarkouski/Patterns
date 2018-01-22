using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class School : EducationalInstitution
    {


        protected override void Enter()
        {
            Console.WriteLine("Congratulations!!! You have been enrolled in a school.");
        }

        protected override void Study()
        {
            Console.WriteLine("Study hard. You may enter a university one day.");
        }

        protected override void PassExams()
        {
            Console.WriteLine("Exams passed successfully.");
        }

        protected override void GetAttestat()
        {
            Console.WriteLine("You ended school and got attestat.");
        }
    }
}
