using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodCompositeApp.parcel
{
    /*поведение обьекта как часть общего компонента*/
    public interface IParselComponent
    {
        double GetDeclaredPrice(); //получаем общую задекларированную стоимость

        double GetDeclaredWeight(); //получаем общий задекларированный вес

        double GetDeclaredVolume(); //получаем общий задекларированный обЪем

        bool IsComposite(); //посылка имеет вложенность или нет.
    }
}
