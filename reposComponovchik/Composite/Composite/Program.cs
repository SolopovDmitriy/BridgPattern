using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Компоновщик - позволяет группивароть элементы в древовидную структуру*/

            try
            {
                IComposite clienPercelBox = new Box();               
                clienPercelBox.IsComposite(); //  clienPercelBox is IComposite
                Console.WriteLine(clienPercelBox.GetDeclaredPrice());

                clienPercelBox.AddComponent(new Parcel() { DeclaredPrice = 150, Volume = 15, Weight = 35, Sender = "Маша", Recipient = "Вася" });
                clienPercelBox.AddComponent(new Parcel() { DeclaredPrice = 32, Volume = 5, Weight = 50, Sender = "Маша", Recipient = "Вася" });
                clienPercelBox.AddComponent(new Parcel() { DeclaredPrice = 47, Volume = 18, Weight = 5, Sender = "Маша", Recipient = "Вася" });
                Box smallBox = new Box();

                IParselComponent parsel = new Parcel { DeclaredPrice = 13 };
                Console.WriteLine(parsel.GetDeclaredPrice());
                smallBox.AddComponent(parsel);
                smallBox.AddComponent(new Parcel { DeclaredPrice = 14 });
                smallBox.AddComponent(new Parcel { DeclaredPrice = 117 });
                clienPercelBox.AddComponent(smallBox);

                Console.WriteLine($"Total: {clienPercelBox.GetDeclaredPrice()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

//скомпоновыать пример фабричного метода с компоновщиком:
// - 1. проверка перегруза на транспортном средстве
// - 2. проверка ограничений по обьему на транспортном средстве
// - 3. общая стоимость загруженных посылок в транспортное средство
