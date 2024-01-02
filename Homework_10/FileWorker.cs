using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Homework_10
{
    public abstract class FileWorker
    {
        public int MaxFileSize { get; set; }
        public abstract string IncreaseFileSize { get; set; }
        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();

    }

    public class DerivedClass : FileWorker
    {
        string increaseFileSize = "";
        public override string IncreaseFileSize
        {
            get => increaseFileSize;
            set => increaseFileSize = value;
        }

        public override void Delete()
        {

            Console.Write("I can Delete from ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("txt");
            Console.ResetColor();

            Console.Write(" file with max storage ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("128");
            Console.ResetColor();
        }

        public override void Edit()
        {
            Console.Write("I can Edit ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("txt");
            Console.ResetColor();

            Console.Write(" file with max storage ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("128");
            Console.ResetColor();
        }

        public override void Read()
        {
            Console.Write("I can Read from ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("txt");
            Console.ResetColor();

            Console.Write(" file with max storage ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("128");
            Console.ResetColor(); ;
        }

        public override void Write()
        {
            Console.Write("I can Write to ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("txt");
            Console.ResetColor();

            Console.Write(" file with max storage ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("128");
            Console.ResetColor(); ;
        }
    }
}
