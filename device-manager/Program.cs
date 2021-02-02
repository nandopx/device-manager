using Entidades;
using System;
using System.Collections.Generic;

namespace device_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuario = new List<Usuario>();
            Usuario.criarUsuario(usuario);
            Usuario.criarUsuario(usuario);

            Console.Clear();
            Console.WriteLine("===USUARIOS CADASTRADOS===");
            foreach (var item in usuario)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Usuario.editarUsuario(usuario);

            Console.WriteLine();
            Console.WriteLine("===USUARIOS ATUALIZADOS===");
            foreach (var item in usuario)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Usuario.excluirUsuario(usuario);

            Console.WriteLine();
            Console.WriteLine("===USUARIOS ATUALIZADOS===");
            foreach (var item in usuario)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}
