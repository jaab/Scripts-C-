using System;

namespace Calculadora

{
    class Program

    {
        private static void calcular(double a,double b,char c)
        {
            switch(c)
            {
                case '+':
                          Console.WriteLine("\t\tSoma: " + (a + b));
                          Console.ReadLine();
                break;
                case '-':
                          Console.WriteLine("\t\tSubtração: " + (a - b));
                          Console.ReadLine();
                break;
                case '*':
                          Console.WriteLine("\t\tMultiplicação: " + (a * b));
                          Console.ReadLine();
                break;
                case '/':
                          Console.WriteLine("\t\tDivisão: " + (a / b));
                          Console.ReadLine();
                break;
            }

        }

        static void Main(string[] args)
        {
                double num1, num2;
                char op='i';

                Console.Write("\n\n\t\tInsira valor 1: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("\t\tInsira valor 2: ");
                num2 = double.Parse(Console.ReadLine());

                Console.Clear();

            while (op != 's')
            {
                
                Console.WriteLine("\n\n\t\t___________________");
                Console.WriteLine("\t\t+ Para somar");
                Console.WriteLine("\t\t- Para subtrair");
                Console.WriteLine("\t\t/ Para Dividir");
                Console.WriteLine("\t\t* Para Multiplicar");
                Console.WriteLine("\t\ts - Sair");
                Console.WriteLine("\t\t_______________________");
                Console.Write("\t\tEscolher operação: ");

                op = Convert.ToChar(Console.ReadLine());

                calcular(num1,num2,op);

                Console.Clear();
            }

        }

    }

}