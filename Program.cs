using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppfirstex
{
    class EX2
    {
        public void tableau()
        {
            Console.WriteLine("enter num");
            int nbr = Convert.ToInt32(Console.ReadLine());

            int[] tab = new int[4] { 1, 2, 3, 5 };



            for (int i = 0; i > tab.Length; i--)
            {
                if (tab[i] > nbr)
                {
                    tab[i + 1] = tab[i];
                    tab[i - 1] = nbr;

                }

            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("le tableau : " + tab[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EX2 ex = new EX2();
            ex.tableau();

        }
    }

}

