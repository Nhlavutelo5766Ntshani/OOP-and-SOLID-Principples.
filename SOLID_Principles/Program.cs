using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class GarageStation
    {
        public void DoOpenGate()
        {
            //Open the gate functionality 

        }
        public void PerfomService()
        {
            //Check if the gate is opened
            //finish the vehicle service
        }
        public void DoCloseGate()
        {
            //Close the gate functionality 
        }

    }
    public class Account
    {
        public decimal Interest { get; set; }
        public decimal Balance { get; set; }
        // members and function declaration

        public decimal CalcInterest(string accType)
        {
            if (accType == "Regular")  //Savings
            {
                Interest = (Balance * 4) / 100;
                if (Balance < 1000) Interest -= (Balance * 2) / 100;
                if (Balance < 50000) Interest += (Balance * 4) / 100;
            }
            else if (accType == "Salary") // Salary Savings
            {
                Interest = (Balance * 5) / 100;
            }
            else if (accType == "Corporate")
            {
                Interest = (Balance * 3) / 100;
            }
            return Interest;
        }

    }
    interface IAccount
    {
        // members and functionality , properties
        decimal Balance { get; set; }
        decimal CalcInterest();
    }
    // regular savings account
    public class RegularSavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 4) / 100;
            if (Balance < 1000) Interest -= (Balance * 2) / 100;
            if (Balance < 50000) Interest += (Balance * 4) / 100;
            return Interest;
        }
    }
    public class SalarySavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 5) / 100;
            return Interest;
        }
    }
    public class CorporateAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 3) / 100;
            return Interest;
        }
    }

}
