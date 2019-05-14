using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal A1 = new Animal("", "");
            Console.WriteLine("******task 1 *********");
            Console.Write("Please enter the animal name");
            A1.Name = Console.ReadLine();
            Console.Write("Please enter the animal sound");
            A1.Sound = Console.ReadLine();

            Console.WriteLine("\n" + A1.AnimalSays());

            Console.ReadLine();

            Console.WriteLine("**********task1 ***********");
            Console.Write("Please enter the animal name");
            string name = Console.ReadLine();
            Console.Write("Please enter the animal sound");
            string sound = Console.ReadLine();
            Animal A2 = new Animal(name, sound);
            Console.WriteLine("\n" + A2.AnimalSays());

            Console.ReadLine();
        }
    }
    class Animal
    {
        string name;
        string sound;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        public string AnimalSays()
        {
            return $"The {Name} says {Sound}";
        }
        public Animal(string _name, string _sound)
        {
            Name = _name;
            sound = _sound;
        }

    }
}
