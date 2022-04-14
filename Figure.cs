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
        public static ArrayList spisok = new ArrayList
        {
            new Trapezium(4,5,2,7),
            new Pentagon(15,4,12,5),
            new Rhombus(8,9,10,11),
            new Square(12,13,14,15),
            new Triangle(16,17,18,19),
            new Rectangle(17,18,19,20)
        };

        public int x1;
        public int x2;
        public int y1;
        public int y2;
        public String figureName;
        public String getFigureName()
        {
            return figureName;
        }
        //static
        public double getX1()
        {
            return x1;
        }

        public double getX2()
        {
            return x2;
        }

        public double getY1()
        {
            return y1;
        }

        public double getY2()
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
