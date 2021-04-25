using System;

namespace Memento
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //CreateMemento é usado para definir o estado interno do objeto.
            //SetMemento obterá e atribuirá esse estado interno ao originator.
            Originator originator = new Originator();

            //Manter os objetos memento.
            Caretaker caretaker = new Caretaker();

            originator.bike = new Bicicleta("Left", "Shimano", "Azul");
            caretaker.AddMemento(originator.CreateMemento());

            originator.bike = new Bicicleta("Manintou", "Shimano", "Azul");
            caretaker.AddMemento(originator.CreateMemento());

            originator.bike = new Bicicleta("RockShocks", "Sram", "Preta");
            caretaker.AddMemento(originator.CreateMemento());

            Console.WriteLine("\nConfiguração atual: " + originator.GetDetails());

            Console.WriteLine("\nRestaurar a bike para estado original");

            originator.bike = caretaker.GetMemento(0).bike;

            Console.WriteLine("\nConfiguração atual: " + originator.GetDetails());
            Console.ReadKey();
        }
    }
}
