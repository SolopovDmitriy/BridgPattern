using FactoryMethodCompositeApp.parcel;
using System.Collections.Generic;

namespace FactoryMethodCompositeApp
{
    public interface ITransport
    {
        void AddParcel(IParselComponent packageToAdd);

        IComposite VehicleBox { get; set; }

        void Deliver();
    }
}