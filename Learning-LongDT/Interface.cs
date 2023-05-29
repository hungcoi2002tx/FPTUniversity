using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LongDT
{
    internal class Interface
    {
    }
    interface Animal2
    {
        void Move();
    }
    interface Animal3
    {

    }
    class AnThit
    {

    }
    class Cat2 : AnThit, Animal2, Animal3
    {
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
