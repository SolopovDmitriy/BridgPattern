using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodCompositeApp.parcel
{
    /*
    * Box - содержит сложные компоненты которые в свою очередь могут содержать вложенные компоненты 
    */
    public class Box : IComposite, IParselComponent
    {
        // int x;
        private List<IParselComponent> _components;
        public List<IParselComponent> Components => _components; 

        public Box()
        {
            // x = 5;
            _components = new List<IParselComponent>();
        }

        public void AddComponent(IParselComponent x)
        {
            _components.Add(x);
        }

        public double GetDeclaredPrice()
        {
            double total = 0;
            foreach (var item in _components)
            {
                total += item.GetDeclaredPrice();
            }
            return total;
        }

        public double GetDeclaredWeight()
        {
            double total = 0.0d;
            foreach (var item in _components)
            {
                total += item.GetDeclaredWeight();
            }
            return total;
        }

        public double GetDeclaredVolume()
        {
            double total = 0.0d;
            foreach (var item in _components)
            {
                total += item.GetDeclaredVolume();
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

        public override string ToString()
        {
            string total = "Box: ";
            foreach (var item in _components)
            {
                total += item + "\n";
            }
            return total;
        }

    }
}
