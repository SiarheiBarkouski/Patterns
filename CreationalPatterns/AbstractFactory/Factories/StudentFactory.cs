using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatterns.Interfaces;
using CreationalPatterns.Students;

namespace CreationalPatterns.Factories
{
    class StudentFactory : IFactory
    {
        private int mark;
        private Language lang;

        public StudentFactory(int mark, Language lang)
        {
            this.mark = mark;
            this.lang = lang;
        }

        public IStudent CreateStudent()
        {
            if (lang == Language.Foreign)
                return new ForeignStudent();

            if (mark >= 9 && mark <= 10 && lang == Language.Russian)
                return new ExcellentStudent();

            if (mark >= 7 && mark < 9 && lang == Language.Russian)
                return new MiddleStudent();

            if (mark < 4 && mark >= 0 && lang == Language.Russian)
                return new BadStudent();

            Console.WriteLine("Incorrect mark.");
            return null;
        }
    }
}

