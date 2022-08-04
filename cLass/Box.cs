using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cLass
{
    internal class Box 
    {
        //Field
        private double uzunluq;
        private double en;
        private double hundurluk;
        private double geribil= 0;
        
        //Constructor
        public Box()
        {
            //uzunluq = 5;
            Console.WriteLine("ASDFUCK");
        }

        public Box(double uzunluq, double en, double hundurluk)
        {
            this.uzunluq = uzunluq;
            this.en = en;
            this.hundurluk = hundurluk;
        }

        /*~Box()
        {
            Console.WriteLine("Sikdiroza");
            Console.ReadLine();
        }*/

        /*public string GetUzunluq()
        {
            if (uzunluq>=1)
            {
                string a = Convert.ToString(uzunluq);
                return a;
            }
            else
            {
                return geribil;
            }
        }
        public void SetUzunluq(double uzun)
        {
            this.uzunluq = uzun;
        }*/

        public double EN
        {
            get
            {
                if (en>=1)
                {
                    return en;
                }
                else
                {

                    return geribil; 
                } 
            }

            set
            {
                this.en = value;
            }
        }

    }
}