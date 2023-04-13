using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPShapes
{
    internal class Rectangle : Shape
    {
        private int sideA;
        private int sideB;

        public Rectangle(int A, int B)
        {
            this.sideA = A;
            this.sideB = B;
        }
        public override int GetArea()
        {
            return this.sideA * this.sideB;
        }
    }
}
