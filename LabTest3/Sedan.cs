using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest3
{
    class Sedan : Car
    {
        private bool backseatFridge;
        private bool backseatRecliner;

        public Sedan(int vin, int mileage, string make, string model, int seats, bool fridge, bool recliner) : base(vin, mileage, make, model, seats)
        {
            backseatFridge = fridge;
            backseatRecliner = recliner;
        }

        public bool hasFridge()
        {
            return backseatFridge;
        }

        public bool hasRecliner()
        {
            return backseatRecliner;
        }

        public override string ToString()
        {
            string data = base.ToString() + "\n";
            data += "Backseat Fridge: " + backseatFridge + "\n";
            data += "Backseat Recliner: " + backseatRecliner;

            return data;
        }
    }
}
