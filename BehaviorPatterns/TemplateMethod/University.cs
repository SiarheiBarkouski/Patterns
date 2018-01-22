using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class University : EducationalInstitution
    {
        protected override void Enter()
        {
            Console.WriteLine("Congratulations!!! You have been enrolled in a university.");
        }

        protected override void Study()
        {
            Console.WriteLine("Study hard, then you will become a professional.");
        }

        protected override void PassExams()
        {
            Console.WriteLine("Exams passed successfully.");
        }

        protected override void GetAttestat()
        {
            Console.WriteLine("You ended university and got attestat.\nNow you may work anywhere you like.");
        }
    }
}
