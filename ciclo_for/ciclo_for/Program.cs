using System;

namespace ciclo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[5];
            int menor2=0;
            int maior2=0;

            for (i = 0; i < a.Length; ++i)
            {
                Console.WriteLine("Introduza o " + (i) + " valor:");

                a[i] = Int32.Parse(Console.ReadLine()); //coverte texto para inteiro
                //Console.Clear();

                if (a[i] >= a[i+1])
                {
                    maior2 = a[i];
                   
                }
                else
                {
                    menor2 = a[i];
                   
                }
                
            }

            
                Console.WriteLine("menor: " + menor2 + "maior: " + maior2);
            
            

        }
    }
}
