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
using GreenFox;

namespace Exercise7_FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int x = 0, y = 0, height = 10, width = 10;
            var foxDraw = new FoxDraw(canvas);
            FourSquare(foxDraw, x, y, height, width);
        }

        public static void FourSquare(FoxDraw foxDraw, int x, int y, int height, int width)
        {
            foxDraw.BackgroundColor(Colors.LightGray);
            var random = new Random();
            for (int i = 0; i < 4; i++)
            {
              
                foxDraw.DrawRectangle(x, y, height, width);
                x = (x+5)*2;
                y = (y+5)*2;
                height *= 2;
                width *= 2;
                foxDraw.FillColor(Color.FromRgb((byte)random.Next(), (byte)random.Next(), (byte)random.Next()));
                
            }
        }
    }
}
