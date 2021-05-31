using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /*
        Конечный обьект структуры - не имеет вложенных компонентов
     */
    class Parcel : IParselComponent
    {
        public int Weight { get; set; }
        public double Volume { get; set; }
        public double DeclaredPrice { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public Parcel()
        {
            Weight = default;
            Volume = default;
            DeclaredPrice = default;
            Sender = default;
            Recipient = default;
        }
        public Parcel(string send, string receive, int kg, double V, double bucks)
        {
            Weight = kg;
            Volume = V;
            DeclaredPrice = bucks;
            Sender = send;
            Recipient = receive;
        }
        public override string ToString()
        {
            return $"Sender: {Sender};\nRecepient: {Recipient}";
        }
        public double GetDeclaredPrice()
        {
            return DeclaredPrice;
        }
        public bool IsComposite()
        {
            return false;
        }
    }
}
