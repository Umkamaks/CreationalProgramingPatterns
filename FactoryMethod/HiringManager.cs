using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class HiringManager
    {
        public abstract IInterviewer MakeInterviewer();
        public void TakeInterview()
        {
            IInterviewer interviewer = this.MakeInterviewer();
            interviewer.AskQuestions();
        }

    }
}
