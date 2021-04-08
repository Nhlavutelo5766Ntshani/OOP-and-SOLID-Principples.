using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Tutorial
    {
        protected int TutorialID;
        protected string TutorialName;

        public void SetTutorial(int pID,string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public void SetTutorial(string pName)
        {
            TutorialName = pName;
        }
        public string GetTutorial()
        {
            return TutorialName;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial pTutor = new Tutorial();
            pTutor.SetTutorial(1, "First Tutorial");
            Console.WriteLine(pTutor.GetTutorial());
            pTutor.SetTutorial("Second Tutorial");
            Console.WriteLine(pTutor.GetTutorial());
            Console.ReadKey();

        }
    }

}
