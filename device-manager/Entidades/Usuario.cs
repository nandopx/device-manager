using device_manager;
using System;
using System.Collections.Generic;

namespace Entidades
{
    class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public Usuario ()
        {
        }

        public Usuario ( string nome, string cPF, string email )
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
        }

        public static void criarUsuario ( List<Usuario> usuario )
        {
            Console.Clear();
            Console.WriteLine( "===== CADASTRO DE USUARIO =====\n" );
            Console.Write( "Nome: " );
            var nome = Console.ReadLine();
            Console.Write( "CPF: " );
            var cpf = Console.ReadLine();
            Console.Write( "Email: " );
            var email = Console.ReadLine();
            usuario.Add( new Usuario( nome, cpf, email ) );
            Console.Clear();
            Console.WriteLine( "Usuário cadastrado com sucesso!" );
            Console.Write( "Deseja cadastrar outro? (s-sim/ n-não): " );
            var resposta = char.Parse( Console.ReadLine().ToLower() );
            if (resposta == 's')
                criarUsuario( usuario );
            else
                Menu.MenuUsuarios();
        }

        public static void editarUsuario ( List<Usuario> usuario )
        {
            Console.Clear();
            Console.WriteLine( "===== EDIÇÃO DE USUARIO =====\n" );
            Console.Write( "CPF a editar: " );
            var cpf = Console.ReadLine();
            var editar = usuario.Find( x => x.CPF == cpf );
            Console.Write( "Nome: " );
            editar.Nome = Console.ReadLine();
            Console.Write( "CPF: " );
            editar.CPF = Console.ReadLine();
            Console.Write( "Email: " );
            editar.Email = Console.ReadLine();
            Console.WriteLine( "Usuário editado com sucesso!" );
            Console.Write( "Deseja editar outro? (s-sim/ n-não): " );
            var resposta = char.Parse( Console.ReadLine().ToLower() );
            if (resposta == 's')
                editarUsuario( usuario );
            else
                Menu.MenuUsuarios();
        }

        public static void excluirUsuario ( List<Usuario> usuario )
        {
            Console.Clear();
            Console.WriteLine( "===== EXCLUSAO DE USUARIO =====\n" );
            Console.Write( "CPF a excluir: " );
            var cpf = Console.ReadLine();
            usuario.Remove( usuario.Find( x => x.CPF == cpf ) );
            Console.WriteLine( "Usuário excluído com sucesso!" );
            Console.Write( "Deseja excluir outro? (s-sim/ n-não): " );
            var resposta = char.Parse( Console.ReadLine().ToLower() );
            if (resposta == 's')
                excluirUsuario( usuario );
            else
                Menu.MenuUsuarios();
        }

        public static void ListarUsuarios ( List<Usuario> usuario )
        {
            Console.Clear();
            Console.WriteLine( "===== LISTA DE USUARIOS =====\n" );
            if (usuario.Count > 1)
            {
                foreach (var item in usuario)
                {
                    Console.WriteLine( item.ToString() );
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine( "Nenhum usuário localizado!" );
            }

            Console.ReadKey();
            Menu.MenuUsuarios();
        }

        public static void ConsultaPorCPF ( List<Usuario> usuario )
        {
            Console.Clear();
            Console.WriteLine( "===== CONSULTA POR CPF =====\n" );
            Console.Write( "CPF a consultar: " );
            var cpf = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine( usuario.Find( x => x.CPF == cpf ) );
            Console.ReadKey();
            Menu.MenuUsuarios();

        }

        public override string ToString ()
        {
            return "Nome: "
                + Nome
                + "\n"
                + "CPF: "
                + CPF
                + "\n"
                + "E-mail: "
                + Email;
        }
    }
}
