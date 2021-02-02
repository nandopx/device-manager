using System;
using System.Collections.Generic;

namespace Entidades
{
    class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nome, string cPF, string email)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
        }

        public static void criarUsuario(List<Usuario> usuario)
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("CPF: ");
            var cpf = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            usuario.Add(new Usuario(nome, cpf, email));
        }

        public static void editarUsuario(List<Usuario> usuario)
        {
            Console.Write("CPF a editar: ");
            var cpf = Console.ReadLine();
            var editar = usuario.Find(x => x.CPF == cpf);
            Console.Write("Nome: ");
            editar.Nome = Console.ReadLine();
            Console.Write("CPF: ");
            editar.CPF = Console.ReadLine();
            Console.Write("Email: ");
            editar.Email = Console.ReadLine();
        }

        public static void excluirUsuario(List<Usuario> usuario)
        {
            Console.Write("CPF a excluir: ");
            var cpf = Console.ReadLine();
            usuario.Remove(usuario.Find(x => x.CPF == cpf));
        }

        public static void ConsultarUsuario(List<Usuario> usuario)
        {
            Console.Write("CPF: ");
            var cpf = Console.ReadLine();
            Console.WriteLine(usuario.Find(x => x.CPF == cpf));
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + "\n"
                +"CPF: "
                + CPF
                + "\n"
                + "E-mail: "
                + Email;
        }
    }
}
