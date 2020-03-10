using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircrafts myAircraft = new Aircrafts();
            Boats myBoat = new Boats();
            Cars myCar = new Cars();
            Jetskis myJetski = new Jetskis();
            Motorcycles myMotocycle = new Motorcycles();
            Rvs myRv = new Rvs();
            Scooters myScooter = new Scooters();
            Trucks myTruck = new Trucks();

            Station MyStation = new Station();
            List<IGasStation> Arrangment = MyStation.MakeGasStation();
        }
    }
}
