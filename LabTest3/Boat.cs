using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest3
{
    class Boat : Vehicle
    {
        private bool radar;

        public Boat(int vin, int mileage, string make, string model, bool radar) : base(vin, mileage, make, model)
        {
            this.radar = radar;
        }

        public bool hasRadar()
        {
            return radar;
        }

        public override string ToString()
        {
            string data = base.ToString() + "\n";
            data += "Has Radar: " + radar;

            return data;
        }
    }
}
