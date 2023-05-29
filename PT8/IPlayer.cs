using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PT81s
{
    public interface IPlayer
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
        public int Speed { get; set; }
        public int Power { get; set; }


        public void GetInfo();
    }
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
        public int Speed { get; set; }
        public int Power { get; set; }

        public void GetInfo()
        {
            double average = (Attack + Defense + Stamina + Speed + Power) / 5;
            Console.WriteLine($"Name : {Name} ,Age: {Age} , Average: {average}");
        }

        public Player(string name, int age, int attack, int defense, int stamina, int speed, int power)
        {
            Name = name;
            Age = age;
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
            Speed = speed;
            Power = power;
        }

        public Player()
        {
        }
    }
    public delegate void ActionDelegate();
    public class Club<T> : IEnumerable<T> where T : IPlayer
    {
        private List<T> players = new List<T>();

        public event ActionDelegate AttackEvent;
        public event ActionDelegate DefenseEvent;

        public IEnumerator<T> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public void Add(T t)
        {
            players.Add(t);
            double average = (t.Attack + t.Defense * t.Stamina + t.Speed + t.Power) / 5.0;

            if (average > 80)
            {
                AttackEvent += new ActionDelegate(t.GetInfo);
            }
            else if (average > 60 && average < 80)
            {
                DefenseEvent += new ActionDelegate(t.GetInfo);
            }
        }

        public void RaiseAttackEvent()
        {
            if (AttackEvent != null)
            {
                AttackEvent();
            }
            else
            {
                Console.WriteLine("No players");
            }
        }

        public void RaiseDefenseEvent()
        {
            if (DefenseEvent != null)
            {
                DefenseEvent();
            }
            else
            {
                Console.WriteLine("No players");
            }
        }
    }
    public class Controller
    {
        Club<Player> players = new Club<Player>();
        public void CreateNewPlayer()

        {

            Verification veri = new Verification();
            Console.Write("Nhap Name: ");
            String name = Console.ReadLine();
            int age = veri.InputInteger("Nhap Age: ", 0, 40);
            int attack = veri.InputInteger("Nhap Attack: ", 0, 100);
            int defense = veri.InputInteger("Nhap Defense: ", 0, 100);
            int stamina = veri.InputInteger("Nhap Stamina: ", 0, 100);
            int speed = veri.InputInteger("Nhap Speed: ", 0, 100);
            int power = veri.InputInteger("Nhap Power: ", 0, 100);
            Player player = new Player(name, age, attack, defense, stamina, speed, power);
            players.Add(player);
            player.GetInfo();

        }

        public void ListAllPlayers()
        {
            foreach (Player player in players)
            {
                player.GetInfo();
            }
        }

        public void SearchPlayerByName()
        {
            Console.WriteLine("Nhap ten player can tim:");
            String s = Console.ReadLine();
            bool status = false;
            foreach (Player player in players)
            {
                if (player.Name.Equals(s))
                {
                    player.GetInfo();
                    status = true;
                }
            }
            if (!status)
            {
                Console.WriteLine("No player was found");
            }
        }
        public void RaiseAttackEvent()
        {
            players.RaiseAttackEvent();
        }
        public void RaiseDefenseEvent()
        {
            players.RaiseDefenseEvent();
        }
    }
    public class Verification
    {
        public int InputInteger(String msg, int minValue, int maxValue)
        {
            int result = 0;
            bool isValidInput = false;

            do
            {
                Console.WriteLine(msg);
                string input = Console.ReadLine();

                try
                {
                    result = int.Parse(input);

                    if (result > minValue && result < maxValue)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"Enter an integer between {minValue} and {maxValue}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large or too small.");
                }
            } while (!isValidInput);

            return result;
        }
    }


    public class Menu
    {
        private static Controller controller = new Controller();

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Create new Player");
                Console.WriteLine("2. List all players");
                Console.WriteLine("3. Search player by Name");
                Console.WriteLine("4. Raise Attack Event");
                Console.WriteLine("5. Raise Defense Event");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        controller.CreateNewPlayer();
                        break;
                    case 2:
                        controller.ListAllPlayers();
                        break;
                    case 3:
                        controller.SearchPlayerByName();
                        break;
                    case 4:
                        controller.RaiseAttackEvent();
                        break;
                    case 5:
                        controller.RaiseDefenseEvent();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 6);
        }
    }
}
