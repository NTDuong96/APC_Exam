using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Manage_Book_Phone
    {
        public List<Product> List;

        public Manage_Book_Phone()
        {
            List = new List<Product>(6);
        }

        public void input1()
        {
            string sNext;
            Product pr;
            int type;

            while (true)
            {
                Console.WriteLine("enter 1 choose Book | 2 choose Phone");
                
                type = int.Parse(Console.ReadLine());

                if (type ==  1)
                {
                    pr  = new Book();
                }else if(type == 2)
                {
                    pr = new MobilePhone();
                }
                else
                {
                    Console.WriteLine("Please choose 1 or 2");
                    continue;
                }

                pr.input();
                List.Add(pr);

                sNext = Console.ReadLine();
                if ( sNext.ToUpper() == "K" )
                {
                    break;
                }
            }
        }

        public double caculate()
        {
            double result = 0;

            for ( int i=0; i < List.Count; i++ )
            {
                result += List[i].price;
            }

            return result;
        }

        public void display()
        {
            Console.WriteLine("List: ");
            foreach (Product item in List)
            {
                item.output();
            }
        }
    }
}
