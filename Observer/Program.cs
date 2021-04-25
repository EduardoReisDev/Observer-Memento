using System;
using static Observer.Subject;

namespace Observer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ISubject controladorEmail = new ControladorEmail();

            var usuarioA = new UsuarioA();
            var usuarioB = new UsuarioB();
            var usuarioC = new UsuarioC();

            controladorEmail.Registrar(usuarioA);
            controladorEmail.Registrar(usuarioB);
            controladorEmail.Registrar(usuarioC);

            Console.WriteLine("Os usuarios A, B e C cadastraram-se para receber as promoções.\n");
     
            Console.WriteLine("Enviando os emails para os usuarios assinados(usuários cadastrados).\n");

            controladorEmail.EnviarEmail();

            Console.WriteLine("\nO usuário A resolveu cancelar a assinatura e não irá receber mais emails.\n");
     
            controladorEmail.Remover(usuarioA);

            Console.WriteLine("Enviando os emails para os usuarios assinados.\n");
            controladorEmail.EnviarEmail();

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
