using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pt5
{
    internal class B16
    {
        public class Battery {
            private int energy;
            public Battery() {
                energy = 10;
            }
            public void SetEnergy(int value)
            {
                energy = value; 
            }

            public int GetEnergy() {              
                return energy; 
            }

            public void DecreaseEnergy() { 
                energy = energy - 2; 
            }
        }

        public class FlashLamp
        {
            private Boolean status;
            private Battery battery;

            public FlashLamp()
            {
                this.status = false;
                this.battery = new Battery();
                battery.SetEnergy(0);
            }

            public void SetBattery(Battery battery)
            {
                this.battery.SetEnergy(battery.GetEnergy());
            }   
            public int GetBatteryInfo() { 
                return this.battery.GetEnergy();
            }

            public void TurnOn()
            {
                this.status = true;
                if(GetBatteryInfo() > 0)
                {
                    Console.WriteLine("Den Sang");
                }
                else
                {
                    Console.WriteLine("Den khong sang");
                }
            }
            public void TurnOff()
            {
                this.status = false;
                Console.WriteLine("den tat");
            }
        }
        public class TestFlashLamp
        {
            static void Main(string[] args)
            {
                Battery battery = new Battery();
                FlashLamp flashLamp = new FlashLamp();  
                flashLamp.SetBattery(battery);
                flashLamp.TurnOn();
                flashLamp.TurnOff();
                flashLamp.TurnOn();
                flashLamp.TurnOff();
                flashLamp.TurnOn();
                flashLamp.TurnOff();
                flashLamp.TurnOn();
                flashLamp.TurnOff();
                flashLamp.TurnOn();
                flashLamp.TurnOff();
                Console.WriteLine(flashLamp.GetBatteryInfo()); 
            }
        }
    }
}
