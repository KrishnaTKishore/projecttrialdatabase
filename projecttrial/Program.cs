using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecttrial
{
    class Program
    {
        static void Main(string[] args)
        {
            int dis=0,tim=0,sum=0,temp = 1;
            double sum1;
            char ch;
            int[] a = new int[100];
            do
            {
                Console.WriteLine("Enter the distance travelled");
                dis = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the time of cab booking in 24 hr format");
                 tim = Convert.ToInt32(Console.ReadLine());
                if (dis <= 3 && dis > 0)

                    sum = 50;
                else if (dis > 3)
                    sum = 50 + ((dis - 3) * 20);
                else
                { Console.WriteLine("Wrong input"); break; }
                if ((tim > 7 && tim < 9) || (tim > 18 && tim < 21))
                {
                    sum1 = sum + sum * 0.5;
                    Console.WriteLine("the sum amt was {0} but due to high demand the price has risen to {1}", sum, sum1);
                }
                else
                Console.WriteLine("the total ride amount is " + sum);
                Console.WriteLine("Do u want to continue? y for yes or n for no");
                ch=Convert.ToChar(Console.ReadLine());
            

                a[temp] = sum;
                temp++;
            } while (ch == 'y');
        



        }
    }
}
