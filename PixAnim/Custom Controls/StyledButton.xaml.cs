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
    /// Interaction logic for StyledButton.xaml
    /// </summary>
    public partial class StyledButton : UserControl
    {
        enum State
        {
            NORMAL,
            HOVER,
            PRESSED
        }




        private State state;
        private Pen borderPen;
        private Brush hoverBrush;
        private Brush pressedBrush;



        public StyledButton()
        {
            InitializeComponent();

            state = State.NORMAL;
            borderPen = new Pen(new SolidColorBrush(Color.FromRgb(64, 64, 64)), 1f);
            hoverBrush = new SolidColorBrush(Color.FromArgb(64, 255, 255, 255));
            pressedBrush = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
        }



        protected override void OnRender(DrawingContext drawingContext)
        {
            Rect border = new Rect(0, 0, this.ActualWidth, this.ActualHeight);

            switch (state)
            {
                case State.NORMAL:

                    break;

                case State.HOVER:
                    drawingContext.DrawRectangle(hoverBrush, null, border);
                    break;

                case State.PRESSED:
                    drawingContext.DrawRectangle(pressedBrush, null, border);
                    break;
            }

            drawingContext.DrawRectangle(null, borderPen, border);
        }


        
        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            state = State.HOVER;
            this.InvalidateVisual();
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            state = State.NORMAL;
            this.InvalidateVisual();
        }

        private void OnMousePressed(object sender, MouseButtonEventArgs e)
        {
            state = State.PRESSED;
            this.InvalidateVisual();
        }

        private void OnMouseRelease(object sender, MouseButtonEventArgs e)
        {
            state = State.HOVER;
            this.InvalidateVisual();
        }
    }
}
