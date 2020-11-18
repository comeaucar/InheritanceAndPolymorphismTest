using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest3
{
    class Car : Vehicle
    { 
        protected int seats;

        public Car(int vin, int mileage, string make, string model, int seats) : base(vin, mileage, make, model)
        {
            this.seats = seats;
        }

        public int getSeats()
        {
            return seats;
        }

        public override string ToString()
        {
            string data = base.ToString() + "\n";
            data += "Seats: " + seats;

            return data;
        }
    }
}
