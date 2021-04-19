using System;
using System.Collections;

namespace TextRpg
{
    internal class Player
    {
        private string Name;
        private string Class;
        internal int Level { get; set; }
        internal double Exp { get; set; }
        internal double ExpToLevel { get; set; }
        internal int Hp { get; set; }
        internal double dpsMin { get; set; }
        internal double dpsMax { get; set; }

        internal enum Classes : sbyte
        {
            Mage = 1,
            Warrior = 2,
        }


        internal Player(string Name, string Class)
        {
            this.Name = Name;
            this.Class = Class;
        }
        internal double CalcDps(int low, int high)
        => new Random().Next(low, high);

        internal string GetName()
        {
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();

            var firstLetter = name.Substring(0, 1).ToUpper();
            return firstLetter + name.Substring(1).ToLower();

        }

        internal string GetClass()
        {
            bool valid = false;
            int classInt;

            do
            {
                Console.WriteLine("Please Enter The Class You Wish To Be ");
                IList list = Enum.GetValues(typeof(Player.Classes));
                for (int i = 0; i < list.Count; i++)
                {
                    object Class = list[i];
                    Console.WriteLine($"({i + 1}){Class}");
                }
                valid = int.TryParse(Console.ReadLine(), out classInt);
                switch (classInt)
                {
                    default:
                        valid = false;
                        break;
                    case 1: // Mage
                        return "Mage";
                    case 2: // Warrior
                        return "Warrior";
                }
            } while (!valid);
            return string.Empty;
        }
        internal void PrintUserInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Class: {0}", Class);
            Console.WriteLine("Hp: {0}", Hp);
            Console.WriteLine("Level: {0}", Level);
            Console.WriteLine("EXP: {0} : {1}", Exp, ExpToLevel);

        }
    }
}