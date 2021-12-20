using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // создать абстрактное свойство
            // конструктор, устанавливающий значение по умолчанию для значения
            // абстрактный метод, который выводит звук, который издает животное
            // неабстрактный метод, который выводит на консоль сперва название а затем звук

            Cat cat = new Cat("Мурка");

            cat.ShowInfo();
            
            Dog dog = new Dog("Шарик");

            dog.ShowInfo();
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract string OtherAnimals { get; set; } // создать абстрактное свойство


        public Animal(string otherAnimals) // конструктор, устанавливающий значение по умолчанию для значения
        {
            OtherAnimals = otherAnimals;
        }

        public abstract void Say();  // абстрактный метод, который выводит звук, который издает животное


        public void ShowInfo() // неабстрактный метод, который выводит на консоль сперва название а затем звук
        {
            Console.WriteLine(OtherAnimals);
            Say();
        }

    }


    class Cat : Animal
    {
        private string taste;
        private static string otherAnimals;

        public override string OtherAnimals { get => otherAnimals; set => otherAnimals = value; }

        public Cat(string neme, string taste)
              : base(otherAnimals)
        {
            this.taste = taste;
        }

        public Cat(string otherAnimals) : base(otherAnimals)
        {
        }

        public override void Say()
        {
            Console.WriteLine("мяу");
        }

        
     }
    
    class Dog : Animal
    {
        private string taste;
        private static string otherAnimals;

        public override string OtherAnimals { get => otherAnimals; set => otherAnimals = value; }

        public Dog(string neme, string taste)
              : base(otherAnimals)
        {
            this.taste = taste;
        }

        public Dog(string otherAnimals) : base(otherAnimals)
        {
        }

        public override void Say()
        {
            Console.WriteLine("гав");
        }
        
        

    }

}

    
