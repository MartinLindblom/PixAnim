using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace PixAnim
{
    class CanvasPixel
    {
        public float scale;

        float xOrigin;
        float yOrigin;
        float xOffset;
        float yOffset;

        Color color;



        public CanvasPixel(float _xOrigin, float _yOrigin, Color _color)
        {
            xOrigin = _xOrigin;
            yOrigin = _yOrigin;

            scale = 1f;

            color = _color;
        }

        public void Render(DrawingContext c)
        {
            Rect rectangle = new Rect(xOrigin + xOffset, yOrigin + yOffset, scale, scale);

            Brush brush = new SolidColorBrush(color);
            Pen pen = new Pen(new SolidColorBrush(Color.FromArgb(255, 0, 0, 0)), 0.5f);

            c.DrawRectangle(brush, pen, rectangle);
        }
    }
}
