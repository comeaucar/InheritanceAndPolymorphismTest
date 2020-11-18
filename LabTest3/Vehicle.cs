using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest3
{
    class Vehicle
    {
        protected int vehicleIdNumber;
        protected int mileage;
        protected string make;
        protected string model;

        public Vehicle(int vin, int mileage, string make, string model)
        {
            vehicleIdNumber = vin;
            this.mileage = mileage;
            this.make = make;
            this.model = model;
        }

        public int getVehicleIdNumber()
        {
            return vehicleIdNumber;
        }

        public int getMileage()
        {
            return mileage;
        }

        public string getMake()
        {
            return make;
        }

        public string getModel()
        {
            return model;
        }

        public override string ToString()
        {
            string data = "\nVehicle ID: " + vehicleIdNumber + "\n";
            data += "Mileage: " + mileage + "\n";
            data += "Make: " + make + "\n";
            data += "Model: " + model;

            return data;
        }
    }
}
