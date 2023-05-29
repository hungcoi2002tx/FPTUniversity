using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LongDT
{
    internal class Abtract
    {
        static void Main(string[] args)
        {
            //Animal1 animal1 = new Animal1();
        }
    }

    abstract class Animal1
    {
        public abstract void Move();

        public void InputInfo()
        {

        }
    }
    class Cat1 : Animal1
    {
        public override void Move()
        {
            
        }
    }
}
