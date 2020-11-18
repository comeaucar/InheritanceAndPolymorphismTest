using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest3
{
    class HatchBack : Car
    {
        private bool foldableSeats;

        public HatchBack(int vin, int mileage, string make, string model, int seats, bool foldable) : base(vin, mileage, make, model, seats)
        {
            foldableSeats = foldable;
        }

        public bool hasFoldableSeats()
        {
            return foldableSeats;
        }

        public override string ToString()
        {
            string data = base.ToString() + "\n";
            data += "Foldable Seats: " + foldableSeats;

            return data;
        }
    }
}
