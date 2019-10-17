using System;

namespace salarios_aumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.	Elabore um programa que calcule e mostre o salário e os 
             * respetivos aumentos de dez funcionários de acordo com a seguinte regra: Salários até 300, 
             * aumento de 50%; Salários maiores que 300, aumento de 30%. 
             * O programa deve mostrar o salário antes e depois do aumento. */

            int i, aumento50 = 0 , aumento30 = 0;
            int[] a = new int[10];
            
            for (i = 0 ; i < a.Length ; i++)
            {
                Console.WriteLine("\nIntroduza salario " + (i+1) + ":");
                a[i] = Convert.ToInt16(Console.ReadLine());

                if (a[i] <=300)
                {
                aumento50 += (a[i] * 50)/100 + a[i];
                Console.WriteLine("Salario : " + a[i]+ " / Salario com aumento 50% : " + aumento50+"\n");
                }
                else
                {
                aumento30 += (a[i] *30)/100 + a[i];
                Console.WriteLine("Salario : " + a[i] + " / Salario com aumento 30% : " + aumento30);
                }
            }
        }
    }
}
