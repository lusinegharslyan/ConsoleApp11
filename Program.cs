using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{


    class Cage<T>
    {
        public Cage(T t)
        {
            this.t = t;
        }

        public T t { get; set; }
    }


    class Animal
    {
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }


    class Dog:Animal
    {
        public Dog(string name, int age):base(name,age)
        {
         
        }
              
    }

    class Cat : Animal
    {
        public Cat(string name, int age):base(name, age)
        {

        }
    }

    class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age)
        {
        }
    }

    class Pig : Animal
    {
        public Pig(string name, int age) : base(name, age)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Cage<Dog> dogCage = new Cage<Dog>(new Dog("Sevo", 5));
            Cage<Cat> catCage = new Cage<Cat>(new Cat("Miki", 3));
            

        }
    }
}
