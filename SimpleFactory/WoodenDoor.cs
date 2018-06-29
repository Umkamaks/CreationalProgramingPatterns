using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class WoodenDoor : IDoor
    {
        private float height;
    private float width;

        public WoodenDoor(float height, float width)
        {
            this.height = height;
           this.width = width;
        }
        public float GetHeight()
        {
            return this.height;           
        }

        public float GetWidth()
        {
            return this.width;
        }
    }
}
