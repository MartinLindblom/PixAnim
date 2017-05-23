using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PixAnim
{
    /// <summary>
    /// Interaction logic for GraphicsCanvas.xaml
    /// </summary>
    public partial class GraphicsCanvas : UserControl
    {
        CanvasPixel cp;



        public GraphicsCanvas()
        {
            InitializeComponent();

            cp = new CanvasPixel(200, 200, Color.FromRgb(255, 0, 0));
        }



        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(new SolidColorBrush(Color.FromRgb(35, 35, 35)), null, new Rect(0, 0, this.ActualWidth, this.ActualHeight));
            cp.Render(drawingContext);
        }



        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.MiddleButton == MouseButtonState.Pressed)
            {

            }

            this.InvalidateVisual();
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            
            this.InvalidateVisual();
        }

        private void OnMouseScroll(object sender, MouseWheelEventArgs e)
        {
            Console.WriteLine(e.Delta);
            cp.scale = cp.scale + (0.01f * e.Delta);

            this.InvalidateVisual();
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {

            this.InvalidateVisual();
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {

            this.InvalidateVisual();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {

            this.InvalidateVisual();
        }
    }
}
