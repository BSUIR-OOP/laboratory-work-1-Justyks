using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace OOP1
{
    public class Figure
    {
       

        private int x1;
        private int x2;
        private int y1;
        private int y2;
        private String figureName;
        private String getFigureName()
        {
            return figureName;
        }
        //static
        private double getX1()
        {
            return x1;
        }

        private double getX2()
        {
            return x2;
        }

        private double getY1()
        {
            return y1;
        }

        private double getY2()
        {
            return y2;
        }

        public Figure(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.figureName = GetType().FullName;
            
        }

        public virtual void Draw()
        {
            figureName = figureName.Remove(0, 5);
            Console.WriteLine(getFigureName() + "(" + getX1() + ", " + getY1() + ", " + getX2() + ", " + getY2() + ") ");
        }
    }
}
