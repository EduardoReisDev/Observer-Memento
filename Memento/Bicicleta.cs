using System;

namespace Memento
{
    public class Bicicleta
    {
        public string Suspencao { get; set; }
        public string Marcha { get; set; }
        public string Cor { get; set; }

        public Bicicleta(string Suspencao, string Marcha, string Cor)
        {
            this.Suspencao = Suspencao;
            this.Marcha = Marcha;
            this.Cor = Cor;
        }

        public string GetDetails()
        {
            return "Bicicleta [Suspencao=" + Suspencao + ", Marcha=" + Marcha + ", Cor=" + Cor + "]";
        }
    }
}
