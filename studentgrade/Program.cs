using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentgrade
{
    class Program
    {
        enum grade { A=90, B=80, C=70, D=60 };
        static void Main(string[] args)
        {
            int s1, s2, s3, s4, s5, t;
            double p;
            Console.WriteLine("enter the marks of 5 subjects");
            Console.WriteLine("Maths:");
           s1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Physics");
           s2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chemistry");
            s3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Biology");
           s4= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Botany");
           s5=Convert.ToInt32( Console.ReadLine());
            t =(s1 + s2 + s3 + s4 + s5);
            p = (Convert.ToDouble(t) / 500) * 100;
            Console.WriteLine("Total marks= {0}",t);
            Console.WriteLine("percentage= {1}", p);
            if(p >=(int)grade.A)
                Console.WriteLine("Your grade is A");
                else if (p >= (int)grade.B)
                    Console.WriteLine("Your grade is B");
                else if (p >= (int)grade.C)
                    Console.WriteLine("Your grade is C");
                else if (p >= (int)grade.D)
                    Console.WriteLine("Your grade is D");
                else
                    Console.WriteLine("Fail");

            
            Console.ReadKey();
        }
    }
}
