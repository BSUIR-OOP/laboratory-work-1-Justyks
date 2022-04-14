using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
           
        {
           
            foreach (Figure tempFig in Figure.spisok)
            {
                tempFig.Draw();
            }
        }
    }
}