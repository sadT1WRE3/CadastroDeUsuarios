using System;
using System.Text;


namespace CadastroDeUsuarios.Entities
{
    class Usuario
    {
        public string Email{ get; private set; }
        public string Name { get; private set; }
        public string Password { get; protected set; }


        public Usuario()
        {
        }

        public Usuario(string email, string name, string senha)
        {
            Email = email;
            Name = name;
            Password = senha;
        }

        public override string ToString()
        {
            return
                   "Informações do usuario:" +
                   "Email: " + Email + "\n" + 
                   "Nome: " + Name + "\n" +
                   "Senha: " + Password;

        }
    }
}
