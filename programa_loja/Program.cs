using System;

namespace programa_loja
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.	Elabore um programa para uma loja, que utiliza o código P para transações a 
             * pronto pagamento, C para transações a prazo “Crédito” e S para sair do programa.
                O programa deve receber o código e o valor das transações, no máximo 10 transações
                e deve mostrar à saída o seguinte:
                - valor total das compras a pronto pagamento;
                - valor total das compras a prazo;
                - valor total das compras efetuadas;
           */


            

            char menu;
            int valorp=0 , valorc=0 , contador=0;

            do
            {
                    contador++;
                    Console.Clear();
                    Console.WriteLine("__________PROGRAMA LOJA__________");
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("p. Transacções Pronto Pagamento");
                    Console.WriteLine("c. Transacções a Prazo Crédito");
                    Console.WriteLine("s. Sair");
                    Console.WriteLine("_________________________________");
                    Console.Write("Escolha uma opção: ");
                   
                    menu = Convert.ToChar(Console.ReadLine());
              
                    switch (menu)
                    {
                    case 'p':
                    case 'P':
                            Console.WriteLine("\nIntroduza Valor transacção a pronto " + contador + ": ");
                            valorp += Convert.ToInt32(Console.ReadLine());
                    break;
                    case 'c':
                    case 'C':
                            Console.WriteLine("\nIntroduza Valor transacção a credito " + contador + ": ");
                            valorc += Convert.ToInt32(Console.ReadLine());
                    break;
                    case 's':
                    case 'S':
                    break;
                    default:
                            Console.Clear();
                            Console.WriteLine("Essa opção não existe!!!: ");
                            Console.ReadKey();
                    break;
                    }
            } while (menu != 's' && contador < 10);

                           Console.WriteLine("Valor das compras a pronto: " + valorp);
                           Console.WriteLine("Valor das compras a credito: " + valorc);
                           Console.WriteLine("Valor total das compras efetuadas: " + (valorp + valorc));

        }
    }
}
