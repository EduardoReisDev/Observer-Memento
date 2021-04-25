using System;
using System.Collections.Generic;

namespace Observer
{
    public class ControladorEmail : ISubject
    {
        private readonly List<IObserver> usuarios;

        public ControladorEmail()
        {
            usuarios = new List<IObserver>();
        }

        public void EnviarEmail()
        {
            foreach (var usuario in usuarios)
            {
                usuario.ReceberEmail();
            }
        }

        public void Registrar(IObserver observer)
        {
            usuarios.Add(observer);
        }

        public void Remover(IObserver observer)
        {
            usuarios.Remove(observer);
        }
    }
}
