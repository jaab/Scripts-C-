using System;

namespace pessoas_mais_18_anos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.	Elabore um programa que mostre no ecrã quantas pessoas possuem mais de 18 anos. 
             * O programa deverá ler a idade de 10 pessoas. */

            int i , mais18=0;
            int[] a = new int[10];

            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Introduza idade " + (i+1) + ":");
                a[i] = Convert.ToInt16(Console.ReadLine()); 
                //Console.Clear();
                if (a[i] > 18)
                {
                    mais18 = i; 
                }
            }
            Console.WriteLine("\nCom mais de 18 são : " + mais18+" pessoas!!");
        }
    }
}
