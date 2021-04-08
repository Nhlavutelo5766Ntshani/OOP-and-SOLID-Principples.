using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new Circle();
            Console.WriteLine(shape.GetShape());
            var Shape = new Triangle();
            Console.WriteLine(Shape.GetShape());

            IAutomobile automobile = new Jeep();
            IAutomobile Automobile = new SUV();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobile.Ignition();
            automobile.Stop();
            Console.Read();
        }
    }
    public abstract class shape
    {
        public abstract string GetShape();
    }
    public class Triangle : shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }
    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
    public interface IOrder
    {
        void AddToCart();
    }
    public interface IOnlineOrder
    {
        void CCProcess();
    }
    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
        public void CCProcess()
        {
            //Process through credit card
        }
    }
    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
    }
    public interface IAutomobile
    {
        void Ignition();
        void Stop();
    }
    public class Jeep : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("Jeep Start");
        }
        public void Stop()
        {
            Console.WriteLine("Jeep Stopped.");
        }
    }
    public class SUV : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("SUV Start");
        }
        public void Stop()
        {
            Console.WriteLine("SUV Stopped.");
        }
    }
    public class AutomobileController
    {
        IAutomobile m_Automobile;
        public AutomobileController(IAutomobile automobile)
        {
           // this.m_Automobile.Ignition();
        }
        public void Ignition()
        {
            m_Automobile.Ignition();
        }
        public void Stop()
        {
            m_Automobile.Stop();
        }
    }


}
