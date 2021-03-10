using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Login
    {

        private string login { get; set; } // propriedades para poder mecher na variavel apenas na classe. 
        private string senha { get; set; }
        //public string login= "jefferson123";
        // public string senha = "123";

        public Login()
        {

        }

        public Login (string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }

        public  void TelaLogin()
        {

            

            Console.WriteLine("Login");
            string login = Console.ReadLine();
            Console.WriteLine("Senha");
            string senha = Console.ReadLine();
            Login p = new Login(login, senha);

            if (p.login == "jefferson" && p.senha == "123")
            {
                Menu menu = new Menu();
                menu.menu();
            }
            else
            {
                Console.WriteLine("Login invalido");
            }

            
                Console.WriteLine("Deseja tentar novamente ?");
                string escolha = Console.ReadLine();
            do
            {
                TelaLogin();
            } while (escolha == "s");
            
        } 
      
    
    }
       }

//Tentando implementar get e set com autenticação de senha
/* public Login()
     {

     }



 static void TelaLogin()
     {

         Console.WriteLine("Login:");
         string login = Console.ReadLine();
         Console.WriteLine("Senha:");
         string senha = Console.ReadLine();



         if (login == "jefferson123" && senha == "123")
         {
             Menu p = new Menu(); // Chama a classe menu caso seja verdadeira a condição de login
             p.menu();
         }
         else
         {
             Console.WriteLine("Login invalido");
         }

     } */




