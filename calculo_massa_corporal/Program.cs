using System;

namespace calculo_massa_corporal
{
    class Program
    {
        
            /*Parametro REF, envia e recebe a referência - Indica que um  argumento/valor é passado por referencia, só é passada a sua localização e não valor*/
            private static void calcular(ref double a, ref double b, char c)/*metodo calcular*/
            {

                switch (c)
                {
                    case 'h':
                        a = a /( b*b);

                    if (a >= 24)
                    {
                        Console.WriteLine("\t\tMUITO MAGRO - IMC homem= " + a);
                        Console.ReadLine();
                    }
                    else if (a > 6 && a < 14)
                    {
                        Console.WriteLine("\t\tMAGRO - IMC homem= " + a);
                        Console.ReadLine();
                    }
                    else if (a == 15)
                    {
                        Console.WriteLine("\t\tACEITAVEL - IMC homem= " + a);
                        Console.ReadLine();
                    }
                    else if (a > 16 && a < 24)
                    {
                        Console.WriteLine("\t\tGORDO - IMC homem= " + a);
                        Console.ReadLine();
                    }
                    else if (a >= 25)
                    {
                        Console.WriteLine("\t\tOBESO - IMC homem= " + a);
                        Console.ReadLine();
                    }



                    break;
                    case 'm':
                         a = a /( b * b);
                         Console.WriteLine("\t\tmassa corporal mulher: " + a);
                        Console.ReadLine();
                        break;
                    case 's':
                        break;
                }

            }

            static void Main(string[] args)
            {
                double num1, num2;
                char op = 'i';

                while (op != 's')
                {

                    Console.WriteLine("\n\n\t\t___________________");
                    Console.WriteLine("\t\th homem");
                    Console.WriteLine("\t\tm mulher");
                    Console.WriteLine("\t\ts - Sair");
                    Console.WriteLine("\t\t_______________________");
                    Console.Write("\t\tEscolher operação: ");

                    op = Convert.ToChar(Console.ReadLine());

                    Console.Clear();

                    if (op != 's')
                    {
                        Console.Write("\n\n\t\tInsira peso: ");
                        num1 = double.Parse(Console.ReadLine());

                        Console.Write("\n\n\t\tInsira altura: ");
                        num2 = double.Parse(Console.ReadLine());

                        calcular(ref num1, ref num2, op);
                    }
                    Console.Clear();
                }

            }
        
    }
}
