using System;
/*using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;*/

namespace cLass
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            /*Box b = new Box();
            /*b.SetUzunluq(15555);
            Console.WriteLine(b.GetUzunluq());#1#

            b.EN = -30;
            Console.WriteLine(b.EN);*/

            testA M = new testA();
            M.ProbA = 10;

            testA.testB N = new testA.testB();
            N.ProbB = 20;
            
        }
    }

    class testA
    {
        public int ProbA { get; set; }

        public testA()
        {
            Console.WriteLine("CLASSa");
        }
        
        public class testB
        {
            public int ProbB { get; set; }

            public testB()
            {
                Console.WriteLine("CLASSb");
            }

        }

    }
}