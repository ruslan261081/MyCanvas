using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;

        private int width;
        private int height;

        internal MyButton(Point topLeft, Point bottomRigth)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRigth;

        }
        internal int GetWidth()
        {
            return this.width;
        }
        internal int GetHeihth()
        {
            return this.height;
        }
        internal bool SetTopLeft(Point p)
        {
            if((p.GetX() < this.bottomRight.GetX()) && (p.GetY() > this.bottomRight.GetY()))
            {
                this.topLeft = p;
                this.height = 5;
                this.width = 5;
                return true;
            }
            else
            {
                Console.WriteLine("point is not on the Botom Rigth of button");
                return false;
            }
        }
        internal bool SetBotomRight(Point p)
        {
            if((p.GetX() > this.topLeft.GetX()) && (p.GetY() < this.topLeft.GetY()))
            {
                this.bottomRight = p;
                this.height = 5;
                this.width = 5;
                return true;

            }
            else
            {
                Console.WriteLine("Point is not on the Botom Right of button");
                return false;
            }
        }
        internal Point GetTopLeft()
        {
            return topLeft;
        }
        internal Point GetBottomRigth()
        {
            return bottomRight;
        }

        public override string ToString()
        {
            return $"width {this.width}, heigth {this.height}, topPoint {this.topLeft}, bottomRigth {bottomRight}";
        }
    }
}
