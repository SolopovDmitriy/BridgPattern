using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodCompositeApp.parcel
{
    /*
        Компоновщик - контейнер - он содержит сложные компоненты  - которые могут содержать вложенные компоненты 
    */
    public interface IComposite : IParselComponent
    {
        List<IParselComponent> Components { get; }

        void AddComponent(IParselComponent composite);

        void RemoveComponent(IParselComponent composite);
    }
}
