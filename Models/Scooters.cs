using System;

namespace Interfaces
{
    public class Scooters : IChargeStation
    {
        public string Passengers { get; set; }
        public string Move { get; set; }
        public string AccelerateDirection { get; set; }
        public string Electric { get; set; }
        public double BatteryKWh { get; set; }
        public string ChargeBattery { get; set; }
        public string Wheels { get; set; }

        public override string ToString()
        {
            return $"Scooters has {Wheels}.";
        }
    }
}
