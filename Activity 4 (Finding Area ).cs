using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        class rectangle
        {
            private int length;
            private int width;


            public void setdata()
            {
                Console.WriteLine("enter the length");
                length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the width");
                width = Convert.ToInt32(Console.ReadLine());
            }


            public void displaylength()
            {
                Console.WriteLine("length is : " + length);
            }

            public void displaywdith()
            {
                Console.WriteLine("width is : " + width);
            }

            public void calarea()
            {
                Console.WriteLine("area is : " + length * width);
            }


        }



        static void Main(string[] args)
        {
            rectangle  rec1 = new rectangle();
            rec1.setdata();
            rec1.displaywdith();
            rec1.displaylength();
            rec1.calarea();


            rectangle rec2 = new rectangle();
            rec2.setdata();
            rec2.displaywdith();
            rec2.displaylength();
            rec2.calarea();

            Console.ReadKey();



        }
    }
}
