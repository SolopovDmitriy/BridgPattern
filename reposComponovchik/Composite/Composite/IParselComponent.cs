using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /*поведение обьекта как часть общего компонента*/
    interface IParselComponent
    {
        double GetDeclaredPrice(); //получаем общую задекларированную стоимость

        bool IsComposite(); //посылка имеет вложенность или нет.
    }
}
