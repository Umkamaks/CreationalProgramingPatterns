using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DevelopmentManager developmentManager  = new DevelopmentManager();
            developmentManager.TakeInterview();

            MarketingManager marketingManager = new MarketingManager();
            marketingManager.TakeInterview();

            Console.ReadKey();


        }
    }
}
