using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Station
    {
        public List<Aircrafts> Aircrafts = new List<Aircrafts>();
        public List<Boats> Boats = new List<Boats>();
        public List<Cars> Cars = new List<Cars>();
        public List<Jetskis> Jetskis = new List<Jetskis>();
        public List<Motorcycles> Motorcycles = new List<Motorcycles>();
        public List<Rvs> Rvs = new List<Rvs>();
        public List<Scooters> Scooters = new List<Scooters>();
        public List<Trucks> Trucks = new List<Trucks>();

        public List<IGasStation> MakeGasStation()
        {
            List<IGasStation> Arrangment = new List<IGasStation>();
            Arrangment.Add(new Aircrafts());
            Arrangment.Add(new Boats());
            Arrangment.Add(new Cars());
            Arrangment.Add(new Jetskis());
            Arrangment.Add(new Rvs());
            Arrangment.Add(new Trucks());

            return Arrangment;
        }

        public List<IChargeStation> MakeChargeStaion()
        {
            List<IChargeStation> Arrangment = new List<IChargeStation>();
            Arrangment.Add(new Scooters());

            return Arrangment;
        }
    }
}
