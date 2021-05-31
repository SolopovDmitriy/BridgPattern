using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /*
        Компоновщик - контейнер - он содержит сложные компоненты  - которые могут содержать вложенные компоненты 
    */
    interface IComposite:IParselComponent
    {
        List<IParselComponent> Components { get; }

        void AddComponent(IParselComponent composite);

        void RemoveComponent(IParselComponent composite);
    }
}
