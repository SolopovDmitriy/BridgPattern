using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeAap
{
    class Shape
    {
        private IColorImplementation _colorImplementation;
        
        public Shape(IColorImplementation colorImplementation)
        {
            _colorImplementation = colorImplementation;
        }

        public RGBColorStyle ColorStyle
        {
            get
            {
                return _colorImplementation.ColorStyle;
            }
        }
    }
}
