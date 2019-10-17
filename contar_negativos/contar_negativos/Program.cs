using System;

namespace contar_negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=0, neg=0;
            double num=0;

            while(cont<5)
            {
                Console.Write("\t digite um numero: ");
                num = Convert.ToDouble(Console.ReadLine());

                if (num < 0)
                {
                  neg = neg + 1;
                }
                cont++; //cont=cont+1
            }
            Console.WriteLine("\t A quantidade de numeros negativos è : "+ neg +"\n");
        }
    }
}
