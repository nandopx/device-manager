using Entidades;
using System;
using System.Collections.Generic;

namespace device_manager
{
    class Menu
    {
        public static List<Usuario> usuario { get; set; } = new List<Usuario>();

        public static void MainMenu ()
        {
            Console.Clear();
            Console.WriteLine("=====  MENU PRINCIPAL =====\n");
            Console.WriteLine("1 - Usuários");
            Console.WriteLine("2 - Aparelhos");
            Console.WriteLine("3 - Linhas");
            Console.WriteLine("4 - Sair");
            Console.Write("\nOpção: ");
            var opcao = int.Parse( Console.ReadLine() );

            switch (opcao)
            {
                case 1: MenuUsuarios(); break;
                case 2: MenuAparelhos(); break;
                case 3: MenuLinhas(); break;
                case 4: SairDoPrograma(); break;
                default: Console.WriteLine("Opção inválida!"); break;
            }

        }

        public static void MenuUsuarios ()
        {
            Console.Clear();
            Console.WriteLine( "=====  USUÁRIOS =====\n" );
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Editar usuário");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("4 - Consulta por CPF");
            Console.WriteLine("5 - Listar todos os usuários" );
            Console.WriteLine("6 - Voltar");
            Console.Write( "\nOpção: " );
            var opcao = int.Parse( Console.ReadLine() );

            switch (opcao)
            {
                case 1: Usuario.criarUsuario(usuario); break;
                case 2: Usuario.editarUsuario(usuario); break;
                case 3: Usuario.excluirUsuario(usuario); break;
                case 4: Usuario.ConsultaPorCPF( usuario ); break;
                case 5: Usuario.ListarUsuarios( usuario); break;
                case 6: MainMenu(); break;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        }

        public static void MenuAparelhos ()
        {
            Console.Clear();
            Console.WriteLine( "=====  APARELHOS =====\n" );
            Console.WriteLine( "1 - Cadastrar aparelho" );
            Console.WriteLine( "2 - Editar aparelho" );
            Console.WriteLine( "3 - Excluir aparelho" );
            Console.WriteLine( "4 - Voltar" );
            Console.Write( "\nOpção: " );
            var opcao = int.Parse( Console.ReadLine() );
        }

        public static void MenuLinhas ()
        {
            Console.Clear();
            Console.WriteLine( "=====  LINHAS =====\n" );
            Console.WriteLine( "1 - Cadastrar linha" );
            Console.WriteLine( "2 - Editar linha" );
            Console.WriteLine( "3 - Excluir linha" );
            Console.WriteLine( "4 - Voltar" );
            Console.Write( "\nOpção: " );
            var opcao = int.Parse( Console.ReadLine() );
        }

        public static void SairDoPrograma ()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar o programa!");
            Console.ReadKey();
            Environment.Exit( 0 );
        }
    }
}
