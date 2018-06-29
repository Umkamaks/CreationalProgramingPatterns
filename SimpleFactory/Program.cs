using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IDoor door = new DoorFactory().CreateDoor(100,200);
            Console.WriteLine($"Ширина - {door.GetWidth()},  Высота - {door.GetHeight()}");
            Console.ReadKey();
        }
    }
}
