using System;

namespace Interfaces
{
    public class Rvs : IGasStation
    {
        public string Engine { get; set; }
        public string Passengers { get; set; }
        public string Move { get; set; }
        public string AccelerateDirection { get; set; }
        public string Gas { get; set; }
        public string Wheels { get; set; }
        public string Doors { get; set; }

        public override string ToString()
        {
            return $"Rvs has an {Engine}.";
        }
    }
}
