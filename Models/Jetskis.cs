using System;

namespace Interfaces
{
    public class Jetskis : IGasStation
    {
        public string Engine { get; set; }
        public string Passengers { get; set; }
        public string Move { get; set; }
        public string AccelerateDirection { get; set; }
        public string Gas { get; set; }
        public string Jet { get; set; }

        public override string ToString()
        {
            return $"Jetskis has an {Engine}.";
        }
    }
}
