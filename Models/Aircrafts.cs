using System;

namespace Interfaces
{
    public class Aircrafts : IGasStation
    {
        public string Engine { get; set; }
        public string Passengers { get; set; }
        public string Gas { get; set; }
        public string Propeller { get; set; }
        public string Doors { get; set; }
        public string Jet { get; set; }

        public override string ToString()
        {
            return $"Aircraft has an {Engine}.";
        }
    }
}
