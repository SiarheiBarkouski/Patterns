using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class EducationalInstitution
    {
        public void End()
        {
            Enter();
            Study();
            PassExams();
            GetAttestat();
        }

        protected abstract void Enter();

        protected abstract void Study();

        protected abstract void PassExams();

        protected abstract void GetAttestat();
    }
}
