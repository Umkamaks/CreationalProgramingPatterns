using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Спросить о шаблонах проектирования");
        }
    }
}
