using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string ns1;
            int n1;
            
            Dictionary<int, int> searchnumbers = new Dictionary<int, int>();
          
            for (int i = 0; i < 10; i = i+ 1)
            {
                Console.Write("Please enter a number: ");
                ns1 = Console.ReadLine();
                n1 = Convert.ToInt32(ns1);

                searchnumbers.Add(n1, n1);
            }
          
            Console.Write("Please enter a number: ");
            ns1 = Console.ReadLine();
            n1 = Convert.ToInt32(ns1);

            Console.WriteLine(searchnumbers[n1]);
        }
    }
}
