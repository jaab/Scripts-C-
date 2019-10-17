using System;

namespace jogo_adivinha_numero
{
    class Program
    {
        static void Main(string[] args)
        {
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
          
            string jogador1 = "";
            string jogador2 = "";
            int num = 0 , adv = 0 , i , menu = 0;
            
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Jogar");
                Console.WriteLine("0. Sair");
                Console.WriteLine();
                Console.WriteLine("Escolha uma opção: ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        Console.WriteLine("Introduza o nome do 1º jogador: ");
                        jogador1 = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Introduza o nome do 2º jogador: ");
                        jogador2 = Convert.ToString(Console.ReadLine());

                        Console.WriteLine(jogador1+" Introduza valor [1 a 20] para "+ jogador2 + " advinhar: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (num >= 1 && num <= 20)
                        {  
                            for (i = 1; i <= 3; i++)
                            {
                                Console.WriteLine(jogador2+" Adivinhe o numero: ");
                                adv = Convert.ToInt32(Console.ReadLine());

                                if (num == adv)
                                {
                                    Console.Clear();
                                    Console.WriteLine(jogador2+" advinhou parabéns!!!: ");
                                    break;
                                }
                                else if (num != adv)
                                {
                                    Console.WriteLine(jogador2+" só tem mais "+(3-i)+" oportunidades!!");
                                    if(adv<num)
                                    {
                                    Console.WriteLine(jogador2 + " o numero advinhar é mais alto!!");
                                    }
                                    else
                                    {
                                    Console.WriteLine(jogador2 + " o numero advinhar é mais baixo!!");
                                    }
                                }
                                else
                                {
                                 break;
                                }
                            }
                        }
                    Console.ReadKey();    
                    break;
                    case 0:
                    break;
                    default:
                    Console.Clear();
                    Console.WriteLine("Essa opção não existe!!!: ");
                    Console.ReadKey();
                    break;
                }
            } while (menu != 0); 

           

        }
    }
}
