using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    enum MenuTela { Listar = 1, Adicionar, Remover, Entrada, Saida, sair }
    class Menu
    {
        public void menu()
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("Sistema de estoque J&L");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Entrada\n5-Saida\n6-Sair\n");
                string opStr = Console.ReadLine();
                int opInt = int.Parse(opStr); // Transforma opStr em int

                if (opInt > 0 && opInt < 7)
                {
                    Funcoes func = new Funcoes();
                    MenuTela escolha = (MenuTela)opInt; //Escolhe apartir do dado de entrada do opInt
                    switch (escolha)
                    {
                        case MenuTela.Listar:  //Instancia o enum Menu Tela
                            func.Listagem();
                            break;

                        case MenuTela.Adicionar:  //Instancia o enum Menu Tela
                            func.Cadastro();
                            break;

                        case MenuTela.Remover:  //Instancia o enum Menu Tela
                            func.Remover();
                            break;

                        case MenuTela.Entrada:  //Instancia o enum Menu Tela
                            func.Entrada();
                            break;

                        case MenuTela.Saida:  //Instancia o enum Menu Tela
                            func.Saida();
                            break;

                        case MenuTela.sair:  //Instancia o enum Menu Tela
                            escolheuSair = true;
                            break;
                    }
                }


                else
                {
                    escolheuSair = true; // Caso nenhuma das escolhas seja entre 1 e 6, a variavel se tornara verdadeira fechando o programa.
                }

                Console.Clear(); // Limpa a tela;

                }

            }
        }
        

    }

    

