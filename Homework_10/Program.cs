using System;

namespace Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myClass = new DerivedClass();

            myClass.Read();
            myClass.Write();
            myClass.Edit();
            myClass.Delete();

        }
    }
}
