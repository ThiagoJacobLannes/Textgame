using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textgame
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, help;
            int pre, op1, op2, op3, op4, op5, op6, op7, op8, op9, op10, op11, op12;
            op8 = 1;
            Console.WriteLine("                 A morte e suas decisões neste jogo são permanente e caso algo dê errado, isso resultará no reset automático do jogo");
            Console.WriteLine("                                                                Boa sorte");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  -Olá?");
            Console.WriteLine("  -Alguém aí?");
            Console.WriteLine("      ");
            Console.WriteLine("  1 - ...");
            Console.WriteLine("  2 - ...");
            Console.WriteLine("  3 - ...");
            Console.WriteLine("");
            pre = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("  -Alguém, por favor, eu não sei onde estou");
            Console.WriteLine("  -Está tudo tão escuro");
            Console.WriteLine("");
            Console.WriteLine("  ...");
            Console.WriteLine("");
            Console.WriteLine("  -Por favor...");
            Console.WriteLine("");
            Console.WriteLine("  1 - Estou aqui");
            Console.WriteLine("  2 - Eu estou aqui, não fique com medo");
            Console.WriteLine("  3 - BUUU!");
            Console.WriteLine("");
            op1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (op1 == 3)
            {
                Console.WriteLine("  -Aaaaaaa!!!");
                Console.WriteLine("  -Não me mate, eu imploro!!");
                Console.WriteLine("");
                Console.WriteLine("  1 - Calma, calma, estou brincando!");
                Console.WriteLine("  2 - ~Esmaga-la com o poder da mente~");
                Console.WriteLine("");
                op2 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (op2 == 2)
                {
                    Console.WriteLine("  _Você matou uma pequena criatura indefesa");
                    Console.WriteLine("  _Sem perdão para você!");
                    Console.WriteLine("  _VOCÊ MORREU");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("  -Ufa! que brincadeira mais sem graça!");
                    Console.WriteLine("  -Quem é você?!");
                    Console.WriteLine("  -O que fez comigo?");
                    Console.WriteLine("  -Onde estou?");
                }
            }

            else
            {
                Console.WriteLine("  -Quem é você?!");
                Console.WriteLine("  -O que fez comigo?");
                Console.WriteLine("  -Onde estou?");
            }
            Console.WriteLine("");
            Console.WriteLine("  1 - Eu também não sei, não tem nada que você possa tocar?");
            Console.WriteLine("  2 - Eu não sei, diga tudo que puder sobre onde você esta.");
            Console.WriteLine("");
            op3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (op3 == 1)
            {
                Console.WriteLine("  -Bom, eu sinto que as paredes não são tão firmes");
                Console.WriteLine("  -Está tudo tão escuro... e frio...");
            }
           if (op3 == 2)
            {
                Console.WriteLine("  -Deixa eu ver...");
                Console.WriteLine("  ...");
                Console.WriteLine("  -Apenas sinto que as paredes não são assim tão firmes, de qualquer forma não sei se consigo derruba-las");
                Console.WriteLine("  -Está tudo tão escuro... e frio...");
            }
            Console.WriteLine("  1 - Pegue impulso e chute!!");
            Console.WriteLine("  2 - Ao menos tente! use toda sua força");
            op4 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("  Ok, vamos lá!");
            Console.WriteLine("");
            Console.WriteLine("                                                                               POW!");
            Console.WriteLine("                               A CRIATURA É ARREMESSADA PARA FORA DA CAIXA, AONDE DÁ DE CARA COM SUA GAIOLA FAZENDO UM BARULHO ENORME");
            Console.WriteLine("                                                             A CRIATURA NOTA UMA MOVIMENTAÇÃO VINDO EM SUA DIREÇÃO");
            Console.WriteLine("");
            Console.WriteLine("  1 - SE ESCONDA ATRÁS DA CAIXA!");
            Console.WriteLine("  2 - FIQUE PARADA!");
            Console.WriteLine("  3 - ARRUME A CAIXA E SE ESCONDA ATRÁS DELA");
            Console.WriteLine("");
            op5 = int.Parse(Console.ReadLine());
            if (op5 == 1)
            {
                Console.WriteLine("                                                         O VULTO NOTOU A TENTATIVA DE FUGA");
                Console.WriteLine("");
                Console.WriteLine("                                                              A CRIATURA DESAPARECEU");
                Console.ReadLine();
                return;
            }
            if (op5 == 2)
            {
                Console.WriteLine("                                                        O VULTO NOTOU A PRESENÇA DA CRIATURA");
                Console.WriteLine("");
                Console.WriteLine("                                                              A CRIATURA DESAPARECEU");
                Console.ReadLine();
                return;
            }
            if (op5 == 3)
            {
                Console.WriteLine("                                                     POR POUCO O VULTO NÃO NOTOU A TENTATIVA DE FUGA");
                Console.WriteLine("");
                Console.WriteLine("  Acho que ele já foi embora...");
                Console.WriteLine("  Por que eu não me lembro de nada?!");
                Console.WriteLine("  Por que estou nessa gaiola?");
                Console.WriteLine("  E por que você conhece ler meus pensamentos?");
            }
            Console.WriteLine("");
            Console.WriteLine("  1 - Você não entende que eu também não sei?");
            Console.WriteLine("  2 - Calma, eu também estou na mesma situação que você");
            op6 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("  -Tudo bem... afinal, qual seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("  -" + nome + ", certo?");
            Console.WriteLine("  -Tudo bem " + nome + ", como faremos pra me tirar daqui?");
            Console.WriteLine("");
            Console.WriteLine("  1 - Não sei, alguma ideia?");
            Console.WriteLine("  2 - Já sei!");
            op7 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (op7 == 2)
            {
                Console.WriteLine("  Ops... me esqueci...");
                Console.WriteLine("    -Só me faltava essa... além de ler meus pensamentos sem permissão, ainda é esquecido");
                Console.WriteLine("  Ei, calma aí! Eu te ajudei!");
            }
            Console.WriteLine("    -Tudo bem...");
            Console.WriteLine("");
            Console.WriteLine("  ...");
            Console.WriteLine("");
            Console.WriteLine("  Espera! você lê meus pensamentos, se é tão poderoso assim, pode ser que também saiba fazer outras coisas");
            Console.WriteLine("");
            Console.WriteLine("                                                DIGITE 'HELP' PARA SABER SEUS POSSÍVEIS PODERES CLICHÊS");
            help = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("  1 - INVISIBILIDADE");
            Console.WriteLine("  2 - VOAR");
            Console.WriteLine("  3 - CRIAÇÃO");
            Console.WriteLine("  4 - TELETRANSPORTE");
            Console.WriteLine("");
            op8 = int.Parse(Console.ReadLine());

            if (op8 == 1)
            {
                Console.WriteLine("                                                            CLICHÊ ATÉ DEMAIS, ACHO QUE NÃO...");
                Console.ReadLine();
            }
            if (op8 == 2)
            {
                Console.WriteLine("                                                 E QUAL SERIA A UTILIDADE DISSO? DEFINITIVAMENTE NÃO...");
                Console.ReadLine();
            }
            if (op8 == 4)
            {
                Console.WriteLine("                                                        SERIA BOM! MAS ACHO QUE NÃO É PRA TANTO...");
                Console.ReadLine();
            }
            if (op8 == 3)
            {
                Console.WriteLine("  -CRIAÇÃO?! ENTÃO CRIE ALGO PRA ME TIRAR DESSA GAIOLA!!");
                Console.WriteLine("");
                Console.WriteLine("  1 - Tudo bem, deixa eu pensar");
                Console.WriteLine("  2 - Apodreça nessa gaiola junto da sua grosseria!");
                Console.WriteLine("");
                op9 = int.Parse(Console.ReadLine());

                if (op9 == 2)
                {
                    Console.WriteLine("                                                                     AS YOU WISH");
                    Console.WriteLine("                                                                  A CRIATURA PERECEU");
                    Console.WriteLine("                                                                        SOZINHA");
                    Console.WriteLine("                                                                          ...");
                }
                if (op9 == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("  ...");
                    Console.WriteLine("");
                    Console.WriteLine("  E se...");
                    Console.WriteLine("");
                    Console.WriteLine("  1 - CRIAR CHAVE");
                    Console.WriteLine("  2 - CRIAR UMA ESCADINHA DE MADEIRA");
                    Console.WriteLine("  3 - CRIAR MAÇARICO");
                    Console.WriteLine("");
                    op10 = int.Parse(Console.ReadLine());
                if (op10 == 1)
                    {
                    Console.WriteLine("                                                     A CRIATURA NÃO CONSEGUE ALCANÇAR A FECHADURA");
                    Console.WriteLine("                                                                    TENTE NOVAMENTE");
                    Console.ReadLine();
                    }
                if (op10 == 3)
                    {
                    Console.WriteLine("");
                    Console.ReadLine();
                    }
                if (op10 == 4)
                    {
                    Console.WriteLine("                                                             COM SUA ESCOLHA INESPERADA");
                    Console.WriteLine("                                                         A CRIATURA VIVEU FELIZ PARA SEMPRE");
                    }
                if (op10 == 2)
                    {
                        Console.WriteLine("                                                   AGORA A CRIATURA PODERÁ ALCANÇAR A FECHADURA");
                        Console.WriteLine("                                                                   CRIE A CHAVE!");
                        Console.WriteLine("");
                        Console.WriteLine("  1 - CRIAR CHAVE");
                        op11 = int.Parse(Console.ReadLine());
                        Console.WriteLine("                                                                 VOCÊ CRIOU A CHAVE");
                        Console.WriteLine("                                                          A CRIATURA ABRE A GAIOLA E FOGE");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                                               Parabéns, você ganhou!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                                                    por enquanto...");
                        Console.ReadLine();

                    }
                }
            }
        }  
    }    
}
