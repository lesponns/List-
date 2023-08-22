using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_36_22_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(34);
            numbers.Add(63);
            numbers.Add(2);
            numbers.Add(-72);

            for (int i = 0; i < numbers.Count; i++) 
            {
                Console.Write("{0}.Index Değeri: {1}\n",i,numbers[i]);
            }
            Console.Write("_________________________\n");

            numbers.Remove(2);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write("{0}.Index Değeri: {1}\n", i, numbers[i]);
            }
            Console.Write("_________________________\n");




            Console.ReadKey();
        }
    }
}
