using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest3
{
    class VehicleManager
    {
        private Vehicle[] vehicleList;
        private int numVehicles;
        private int maxVehicles;

        public VehicleManager()
        {
            numVehicles = 0;
            maxVehicles = 100;
            vehicleList = new Vehicle[maxVehicles];
        }

        public void addVehicle(int vin, int mileage, string make, string model, int seats)
        {
            vehicleList[numVehicles] = new Car(vin, mileage, make, model, seats);
            numVehicles++;
        }

        public void addVehicle(int vin, int mileage, string make, string model, int seats, bool foldableSeats)
        {
            vehicleList[numVehicles] = new HatchBack(vin, mileage, make, model, seats, foldableSeats);
            numVehicles++;
        }

        public void addVehicle(int vin, int mileage, string make, string model, int seats, bool fridge, bool recliner)
        {
            vehicleList[numVehicles] = new Sedan(vin, mileage, make, model, seats, fridge, recliner);
            numVehicles++;
        }

        public void addVehicle(int vin, int mileage, string make, string model, bool radar)
        {
            vehicleList[numVehicles] = new Boat(vin, mileage, make, model, radar);
            numVehicles++;
        }

        public string listAllVehicles()
        {
            string data = "";

            for(int i = 0; i < numVehicles; i++)
            {             
                data += vehicleList[i].ToString();
            }

            return data;
        }

    }
}
