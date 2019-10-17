using System;

namespace gera_mumeros_verifica_divisores
{
    class Program
    {
        static void Main(string[] args)
        {

           
            /* double fac = 1, num = 0, i=1;

            Console.WriteLine("Introduza a factorial: ");
            num = Convert.ToDouble(Console.ReadLine());

              for (i = 1; i <= num; i++)
              {
                  fac = fac * i;

              }

              if (num == 0)
              {
                  Console.WriteLine("o factorial é 1");
              }
              else { 
                  Console.WriteLine("o ofactorial è " + fac);
               }

            while (i <= num)
            {
                fac = fac * i;
                i++;
            }

            if (num == 0)
            {
                Console.WriteLine("o factorial é 1");
            }
            else
            {
                Console.WriteLine("o ofactorial è " + fac);
            }*/

            /*criar jogo adivinha o numero, 
            tem 2 jogadores; 
            introduzir nomes dos jogadores;
            um dos jogadores que escolhe um numero só pode introduzir valores de 1 a 20
            o segundo jogador que vai advinhar , tem 3 tentativas para certar no numero
            cada uma das tentativas o utilizador deve ser informado se o numero está abaixo ou acima 
            do valor introduzido.
            no final se acertou deve dizer que acertou e mostrar o numero
            tem de ter menu, jogar e sair
            */


            Console.WriteLine("JOGO ADIVINHA O NUMERO");
            //  Console.WriteLine();
            // Console.WriteLine("1. Jogar");
            //  Console.WriteLine("2. Sair");
            //  Console.WriteLine("escolha uma opção");
            //  string result = Console.ReadLine();
            //  result = Convert.ToString(result);
            string jogador1="";
            string jogador2="";
            //int numdav = 0, numcor = 0;

            int menu = 0;
            do
            {

                Console.WriteLine();
                Console.WriteLine("1. Jogar");
                Console.WriteLine("2. Sair");
                Console.WriteLine("escolha uma opção");
               // Console.Clear();
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        //Console.Clear();

                        Console.WriteLine("Introduza o nome do 1º jogador: ");
                        jogador1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Introduza o nome do 2º jogador: ");
                        jogador2 = Convert.ToString(Console.ReadLine());


                        Console.WriteLine("Introduza um valor de 1 a 20: ");
                        int valores = Convert.ToInt32(Console.ReadLine());

                        if (valores >= 1 && valores <= 20)
                        {
                            int i;
                            for (i = 0; i <= 3; i++)
                            {

                                Console.WriteLine("diga qual é o numero: ");
                                int valores2 = Convert.ToInt32(Console.ReadLine());

                                if (valores2==valores)
                                {
                                    Console.WriteLine("acertou: ");
                                    break;
                                }
                                else if (valores != valores2)
                                {
                                    Console.WriteLine("volte a tentar: ");
                                }
                                else
                                {
                                    break;
                                }

                            }
                        } else
                      
               // Console.ReadKey();    
                break;
                case 2:
                break;
                default:
               // Console.Clear();
               // Console.ReadKey();
                break;
                }
               

            } while (menu != 2);

        }
    }
}
