using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OOP_Principals_Pillars_
{
   public abstract class Shape
    {
        public int b = 20;
        abstract public void calculatedArea();
    }
    
    public class Rectangle : Shape
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle
            {
                b = 200
            };
            obj.calculatedArea();
        }
        public override void calculatedArea()
        {

            Console.WriteLine("Area is");// + (obj.b * obj.b));
            Console.ReadLine();
        }
    }
}
