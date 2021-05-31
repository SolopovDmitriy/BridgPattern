using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FactoryMethodCompositeApp.parcel;

namespace FactoryMethodCompositeApp
{
    abstract class Vehicle : ITransport
    { // my code-------------------------------------------------
        public IComposite VehicleBox { get; set; }
        public int LiftingCapacity { get; set; }
        public int VolumeCapacity { get; set; }


        public void AddParcel(IParselComponent packageToAdd)
        {
            double vehicleBoxWeight = VehicleBox.GetDeclaredWeight();
            double packageToAddWeight = packageToAdd.GetDeclaredWeight();
            if (vehicleBoxWeight + packageToAddWeight > LiftingCapacity)
            {
                Console.WriteLine("Error. Vehicle doesn't have enough LiftingCapacity");
                Console.WriteLine($"LiftingCapacity = {LiftingCapacity}, free space: {LiftingCapacity - vehicleBoxWeight}, " +
                    $"but we want to add {packageToAddWeight}");
                return;
            }

            double vehicleBoxVolume = VehicleBox.GetDeclaredVolume();
            double packageToAddVolume = packageToAdd.GetDeclaredVolume();
            if (vehicleBoxVolume + packageToAddVolume > VolumeCapacity)
            {
                Console.WriteLine("Error. Vehicle doesn't have enough VolumeCapacity");
                Console.WriteLine($"VolumeCapacity = {VolumeCapacity}, free space: {VolumeCapacity - vehicleBoxVolume}, " +
                    $"but we want to add {packageToAddVolume}");
                return;
            }

            VehicleBox.AddComponent(packageToAdd);
        }

        public abstract void Deliver();

        public void ClearBox()
        {
            VehicleBox = new Box();
        }

        public Vehicle()
        {
            VehicleBox = new Box();
        }

    }
}
