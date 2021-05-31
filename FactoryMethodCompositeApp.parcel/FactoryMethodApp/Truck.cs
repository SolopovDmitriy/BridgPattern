using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodCompositeApp.parcel;

namespace FactoryMethodCompositeApp
{
    class Truck : Vehicle, ITransport
    {       

        public void AddParcel(Parcel parcel)
        {
            throw new NotImplementedException();
        }

        // my code-
        public override void Deliver()
        {
            Console.WriteLine("Deliver by truck: ");
            Console.WriteLine(VehicleBox.ToString());            
            ClearBox();
        }
    }
}
