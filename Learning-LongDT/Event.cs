using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LongDT
{
    internal class Event
    {
        //1 tao delegate
        public delegate void Dele(String msg);

        class Process_Event
        {
            public static void Show(String s) {
                Console.WriteLine(s);
            }
            public static void Hide(String s) {  Console.WriteLine(s); }
        }
        class Demo_Event
        {
            //tao event;
            event Dele EV;
            
            public void Register_Event()
            {
                EV += new Dele(Process_Event.Show);
                EV += new Dele(Process_Event.Hide);
            }
            public void Raising_Event()
            {
                //4 kich hoat event
                EV("sss");
            }
        }

        
        static void Main(string[] args)
        {
            // event: xay dung dua tren delegate
            //cac buoc xay dung event
            // b1: tao delegate
            // b2 tao even su dung delegate o buoc 1
            // b3 dang ky/ huy su kien ( dung cac toan tu +=, -= )
            // b4 kich hoat event
            Demo_Event e = new Demo_Event();   
            e.Register_Event();
            e.Raising_Event();
        }
    }
}
