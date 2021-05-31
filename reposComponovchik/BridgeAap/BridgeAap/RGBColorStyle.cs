using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BridgeAap
{
    class RGBColorStyle: IColorSheme
    {
        private Color _color;
        public Color Color
        {
            get
            {
                return _color;
            }
        }
        public RGBColorStyle(Color color)
        {
            _color = color;
        }

        public IColorSheme GetColor()
        {
            //return _color;
            throw new NotImplementedException();
        }
    }
    // HSL и HSV и CMYK
}
