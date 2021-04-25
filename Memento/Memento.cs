using System;
namespace Memento
{
    public class Memento
    {
        public Bicicleta bike { get; private set; }

        public Memento(Bicicleta bike)
        {
            this.bike = bike;
        }
        public string GetDetails()
        {
            return "Memento " + bike.GetDetails() + "]";
        }
    }
}
