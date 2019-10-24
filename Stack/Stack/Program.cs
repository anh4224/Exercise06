using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Pham" , "Ngoc" , "Duy" };

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            //for (int i = 0; i < array.Length; i++)
                //Console.Write(array[i] + " ");
        }     
    }
}
