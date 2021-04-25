using System;
namespace Memento
{
    public class Originator
    {
        public Bicicleta bike;

        public Memento CreateMemento()
        {
            return new Memento(bike);
        }
        public void SetMemento(Memento memento)
        {
            bike = memento.bike;
        }
        public string GetDetails()
        {
            return "Originator" + bike.GetDetails() + "]";
        }
    }
}
