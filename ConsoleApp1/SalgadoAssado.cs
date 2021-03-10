using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SalgadoAssado:Salgado, IEstoque
    {
        public string sabor;
        private int estoque { get; set; }

        public SalgadoAssado()
        {

        }

        public SalgadoAssado(string nome, double preco, string sabor)
        {
            this.nome = nome;
            this.preco = preco;
            this.sabor = sabor;

        }
       

        public void Exibir()
        {
            Console.WriteLine("Nome: " + nome) ;
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Sabor: " + sabor);
            Console.WriteLine("Estoque: " + estoque);

        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Adicionar entrada:");
            Console.WriteLine("Digite a quantidade de entradas");
            int entrada = int.Parse(Console.ReadLine());
            estoque += entrada;
        }

        public void AdicionarSaida()
        {
            Console.WriteLine("Adicionar saida:");
            Console.WriteLine("Digite a quantidade de saidas");
            int saida = int.Parse(Console.ReadLine());
            estoque -= saida;
        }
 
    }
}
