using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /*
     * Box - содержит сложные компоненты которые в свою очередь могут содержать вложенные компоненты 
     */
    class Box : IComposite
    {
        List<IParselComponent> _components;
        public List<IParselComponent> Components { get { return _components; } }
        public Box()
        {
            _components = new List<IParselComponent>();
        }
        public void AddComponent(IParselComponent composite)
        {
            _components.Add(composite);
        }
        public double GetDeclaredPrice()
        {
            double total = 0.0d;
            foreach (var item in _components)
            {
                total += item.GetDeclaredPrice();
            }
            return total;
        }
        public bool IsComposite()
        {
            return true;
        }
        public void RemoveComponent(IParselComponent composite)
        {
            _components.Remove(composite);
        }

       
    }
}
