using System;

namespace media_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Elabore um programa que calcule a idade média de 5 Alunos */

            int i , media=0;
            int[] a = new int[5];

            for (i = 0 ; i<a.Length ; i++)
            {
                Console.WriteLine("Introduza idade " + (i+1) + ":");
                a[i] = Convert.ToInt16(Console.ReadLine()); 
                media = media + a[i];
                //Console.Clear();
            }
            Console.WriteLine("\nA media das idades é: "+(media/5));
        }
    }
}
