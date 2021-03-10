using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    
    class Funcoes
    {
        static List<IEstoque> salgados = new List<IEstoque>();
        public void Listagem()
        {
            Console.WriteLine("Lista de produtos");
            int i = 0;
                foreach(IEstoque salgado in salgados)
            {
                Console.WriteLine("ID " + i);
                salgado.Exibir();
                i++;
            }
            Console.ReadLine();
        }

        public void Cadastro()
        {
            Console.WriteLine("Cadastro de produto");
            Console.WriteLine("1-Salgado Assado\n2-Salgado Frito");
            string opStr = Console.ReadLine();
            int opInt = int.Parse(opStr);
                switch(opInt)
            {
                case 1:
                    CadastrarSalgadoAssado();
                    break;
                case 2:
                    CadastrarSalgadosFritos();

                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }


        public void Entrada()
        {
            Listagem();
            Console.WriteLine("Digite o ID do elemento que você deseja dar entrada");
            int id = int.Parse(Console.ReadLine());
                if (id >=0 && id < salgados.Count)
            {
                salgados[id].AdicionarEntrada();
            }
        }

        public void Saida()
        {
            Listagem();
            Console.WriteLine("Digite o ID do elemento que você deseja dar saida");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < salgados.Count) //salgados.count == caso seja mentor que a quantidade de salgados existentes
            {
                salgados[id].AdicionarSaida();
            }
        }

        public void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o ID do elemento que deseja remover");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < salgados.Count)
            {
                salgados.RemoveAt(id);
            }

        }

        public void CadastrarSalgadoAssado()
        {
            Console.WriteLine("Cadastrando Assados");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preco:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Sabor: ");
            string sabor = Console.ReadLine();
            SalgadoAssado sa = new SalgadoAssado(nome, preco, sabor);
            salgados.Add(sa);

        }

        public void CadastrarSalgadosFritos()
        {
            Console.WriteLine("Cadastrando Fritos");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Sabor: ");
            string sabor = Console.ReadLine();
            SalgadoFrito sf = new SalgadoFrito(nome, preco, sabor);
            salgados.Add(sf);
        }



    }
}
