using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SalgadoFrito:Salgado, IEstoque
    {
        public string sabor;
        private int estoque { get; set; }


        public SalgadoFrito()
        {

        }
        public SalgadoFrito(string nome, double preco, string sabor)
        {
            this.nome = nome;
            this.preco = preco;
            this.sabor = sabor;
        }


        public void Exibir()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Sabor: " + sabor);
            Console.WriteLine("Estoque: " + estoque);
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Adicionar entradas");
            Console.WriteLine("Digite a quantidade de entradas");
            int entradas = int.Parse(Console.ReadLine());
            estoque += entradas;
        }

        public void AdicionarSaida()
        {
            Console.WriteLine("Adicionar saidas");
            Console.WriteLine("Digite a quantidade de saidas");
            int saidas = int.Parse(Console.ReadLine());
            estoque -= saidas;
        }
    }

    
}
