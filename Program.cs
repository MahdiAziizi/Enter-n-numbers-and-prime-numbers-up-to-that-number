using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
    {
            int num, i, ctr, stno,enno;

            Console.Write("\n\n");
            Console.Write("peyda kardan adad aval beyn yek range :");
            Console.Write("\n\n");

            Console.Write("adad shoro range ra vared konid :");
                stno = Convert.ToInt32(Console.ReadLine());
            Console.Write("adad payani range ra vared konid :");
                enno = Convert.ToInt32(Console.ReadLine());
            Console.Write("adad avval beyn {0} va {1} hastan : \n", stno,enno);

            for (num = stno; num <= enno; num++)
            {
                ctr = 0;
                for (i = 2; i <= 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                    Console.Write("{0}", num);
            }
            Console.Write("\n");
            Console.ReadLine();


        }
    }
}
