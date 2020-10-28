using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoNS.InDemoNS.First;
//using DemoNS;
//using DemoNS1;

namespace NamespaceAbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Namespace
            //Person p1 = new Person();
            //List<int> list = new List<int>();
            //Test t1 = new Test();
            //Console.WriteLine();
            #endregion

            #region Abstract - class,method,property 
            //Human human = new Human();//- cann't get instance from abstract class!!!
            //Student student = new Student();
            //student.Name = "Vasif";
            //student.Surname = "Xammedov";
            //student.Fullname();

            //Eagle eagle = new Eagle("Uchdu getdi qushlar");
            //Shark shark = new Shark();
            //eagle.Eat();
            //shark.Eat();
            #endregion

            #region sealed - class - can't get inheritance!!!
            //Person s1 = new Person();
            #endregion

            #region Interface
            Calculate calculate = new Calculate();
            Console.WriteLine(calculate.Sum(10,15));
            calculate.Difference(15, 10);
            #endregion
        }
    }

    #region Interface
    interface ICalc
    {
        int Sum(int n1,int n2);
        void Difference(int n1, int n2);
    }

    interface ITest
    {

    }
    class Test
    {

    }

    class First
    {

    }

    class Calculate : First,ICalc, ITest
    {
        public void Difference(int n1, int n2)
        {
            Console.WriteLine(n1-n2);
        }

        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
    }
    #endregion

    #region sealed - class - can't get inheritance!!!
    //class Test
    //{

    //}
    //sealed class Person:Test
    //{

    //}

    //class Student : Person
    //{

    //}

    #endregion

    #region Abstract - class,method,property

    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal class");
        }
        public Animal(string word)
        {
            Console.WriteLine(word);
        }
        public abstract int MyProperty { get; set; }
        public int Age { get; set; }

        public abstract void Eat();

        public virtual void Live()
        {
            Console.WriteLine("Live as animal");
        }
    }

    abstract class Bird:Animal
    {
        public Bird(string word):base(word)
        {

        }
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public Eagle(string str):base(str)
        {

        }
        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }

    abstract class Fish:Animal
    {

    }

    class Shark : Fish
    {
        public override int MyProperty { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }
    }
    //abstract class Human
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public int Age { get; set; }

    //    public void Fullname()
    //    {
    //        Console.WriteLine($"{Name} {Surname}");
    //    }
    //}

    //abstract class Man : Human
    //{

    //}
    //class Student : Human
    //{

    //}
    #endregion

    #region Namespace
    //class Person
    //{
    //    public Person()
    //    {
    //        Console.WriteLine("NamespaceAbstractInterface");
    //    }
    //}
    #endregion
}
