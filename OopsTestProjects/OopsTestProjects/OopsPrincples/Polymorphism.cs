using System;
using System.Collections.Generic;
using System.Text;

namespace OopsTestProjects.OopsPrincples
{
    public class Polymorphism
    {
        
    }
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        public void DescribeAnimal()
        {
            Console.WriteLine("I an animal");
        }
       
    }
    public class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        public void DescribDog()
        {
            Console.WriteLine("I am dog");
        }
    }
    public  class Test
    {
        //static public void Main(string[] args)
        //{
        //    Animal animal = new Dog();
        //    animal.Eat();// animal class eat will be called
        //    animal.DescribeAnimal();
        //    //Dog dog = new Animal(); incorrect

        //}
        
    }
}
