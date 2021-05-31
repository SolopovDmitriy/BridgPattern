using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodCompositeApp.parcel
{
    /*
        Конечный обьект структуры - не имеет вложенных компонентов
     */
    public class Parcel : IParselComponent
    {
        public int Weight { get; set; }
        public double Volume { get; set; }
        public double DeclaredPrice { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }

        //public Parcel()
        //{
           
        //}

        public Parcel(string sender, string recipient, float decPrice, float volume, int weight)
        {
            Weight = weight;
            Volume = volume;
            DeclaredPrice = decPrice;
            Sender = sender;
            Recipient = recipient;
        }        

        public double GetDeclaredPrice()
        {
            return DeclaredPrice;
        }

        public double GetDeclaredVolume()
        {
            return Volume;
        }

        public double GetDeclaredWeight()
        {
            return Weight;
        }

        public bool IsComposite()
        {
            return false;
        }

        public override string ToString()
        {
            return $"Sender: {Sender}; Recepient: {Recipient}; DeclaredPrice: {DeclaredPrice} ";
        }

    }



}
