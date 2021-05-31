using FactoryMethodCompositeApp.parcel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodCompositeApp
{
    class Ship : Vehicle, ITransport
    {
        // my code-------------------------------------------------
        public override void Deliver()
        {
            Console.WriteLine("Deliver by Ship: ");
            //foreach (Parcel parcel in Parcels)
            //{
            //    Console.WriteLine($"Deliver from {parcel.Sender} to {parcel.Recipient}");
            //}
            ClearBox();
        }
    }
}
