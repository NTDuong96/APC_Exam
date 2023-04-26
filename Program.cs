using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static int menu()
        {
            int choice;
            Console.WriteLine("---- MENU ----");
            Console.WriteLine("1.Input \n2.Display_total_tax \n3.Display");
            Console.WriteLine("4. Exit");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
     
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Manage_Book_Phone mg = new Manage_Book_Phone();

            int choice;
            do
            {
                choice = menu();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter data for array");
                        mg.input1();
                        break;
                    case 2:
                        Console.WriteLine("Display all elements");
                        break;
                    case 3:
                        double a = mg.caculate();
                        Console.WriteLine("Total tax" + a);
                        break;
                    case 4:
                        Console.WriteLine("See you later!");
                        mg.display();
                        break;
                    default: 
                        Console.WriteLine("Choose between 1 - 4");
                        continue;

                }
            } while (choice != 4);


        }
    }
}
