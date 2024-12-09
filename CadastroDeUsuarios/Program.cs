using CadastroDeUsuarios.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao nosso sistema de login ");
            Console.WriteLine("Entre com os seus dados a seguir");
            Console.WriteLine("Digite seu Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite seu Nome:");
            string name = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string senha = (Console.ReadLine());
            int confirmar = 1;

            while (confirmar == 1)
            {
            
            Console.WriteLine("Confirme a sua Senha:");
            string senha2 = (Console.ReadLine());
            if (senha == senha2)
            {
                confirmar = 0;
            }
            else
            {
                Console.WriteLine("As senhas não conferem, por favor confirme novamente");
            }
            }
            Usuario user1 = new Usuario(email, name, senha);

            Console.WriteLine(user1);
        }
    }
}
    