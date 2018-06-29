using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class DoorFactory
    {
        public IDoor CreateDoor(float height, float width)
        {
            return new WoodenDoor(height, width);
        }
    }
}
