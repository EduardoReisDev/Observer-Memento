using System;
using System.Collections.Generic;

namespace Memento
{
    public class Caretaker
    {
        private List<Memento> BikeList = new List<Memento>();

        public void AddMemento(Memento m)
        {
            BikeList.Add(m);
            Console.WriteLine("Bike snapshots:" + m.GetDetails());
        }

        public Memento GetMemento(int index)
        {
            return BikeList[index];
        }
    }
}
