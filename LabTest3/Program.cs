using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager vm = new VehicleManager();
            vm.addVehicle(100, 1000, "ford", "mustang", 4);
            vm.addVehicle(101, 10000, "chryler", "camry", 6, true, false);
            vm.addVehicle(102, 100000, "Landorver", "rangerover", 3, false);
            vm.addVehicle(103, 212, "Buopy", "Cigar Boat", true);

            Console.WriteLine(vm.listAllVehicles());

            Console.ReadKey();

        }
    }
}
