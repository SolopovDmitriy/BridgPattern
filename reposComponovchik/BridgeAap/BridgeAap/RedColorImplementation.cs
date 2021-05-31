using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BridgeAap
{
    class RedColorImplementation : IColorImplementation
    {
        private RGBColorStyle _colorStyle;
        public RGBColorStyle ColorStyle
        {
            get { return _colorStyle;  } 
        }
        public RedColorImplementation()
        {
            _colorStyle = new RGBColorStyle(Color.Red);
        }
    }
}
