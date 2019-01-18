using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_2_Inheritance
{
    public static partial class Practice
    {
        /// <summary>
        /// A.L2.P1/1. Создать консольное приложение, которое может выводить 
        /// на печатать введенный текст  одним из трех способов: 
        /// консоль, файл, картинка. 
        /// </summary>
        public static void A_L2_P1_1()
        {
            Console.WriteLine("Enter your text:");
            var text = Console.ReadLine();
            Console.WriteLine("Choose print type:");
            Console.WriteLine("1- toconsole");
            Console.WriteLine("2- in file");
            Console.WriteLine("3- in image");
            var answerType = Console.ReadLine();
            switch (answerType)
            {
                case "1":
                    {
                        var printer = new ConsolePrinter(text, ConsoleColor.Blue);
                        printer.Print();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You have chosen  printing into file");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You have chosen  printing into image");
                        break;
                    }
            }


        }
        
        public abstract class Printer
        {
            public string printingText { get; set; }
            public abstract void Print(); 

            public Printer(string str)
            {
                printingText = str;
            }
        }

        public class ConsolePrinter : Printer
        {
            public override void Print()
            {
                Console.ForegroundColor = _color;
                Console.WriteLine(printingText);
                Console.ResetColor();
            }

            public ConsolePrinter(string str, ConsoleColor color): base(str)
            {
                 _color = color;
            }
            private ConsoleColor _color;


        }










    }
}
