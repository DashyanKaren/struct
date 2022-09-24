using System;
using MyName;

namespace MyName
{
    class MyClass
    {
        public override string ToString()
        {
            return "Hello";
        }
    }
}

namespace ConsoleApp2
{
    class Program : Object
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.GetType());
            int x = 9;
            string s = x.ToString();
            Console.WriteLine(s);
            Console.WriteLine(myClass.ToString());

        }
    }


}
