using System;

namespace Observer
{
    public interface ISubject
    {
        void Registrar(IObserver observer);
        void Remover(IObserver observer);
        void EnviarEmail();
    }
}
