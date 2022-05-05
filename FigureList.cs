using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class FigureList:Figure
    {
        public static List<Figure> list = new List<Figure>
        {
            new Trapezium(4,5,2,7),
            new Pentagon(15,4,12,5),
            new Rhombus(8,9,10,11),
            new Square(12,13,14,15),
            new Triangle(16,17,18,19),
            new Rectangle(17,18,19,20)
        };
        public FigureList(int x1, int x2, int y1, int y2) : base(x1, x2, y1, y2)
        {

        }
    }
}
