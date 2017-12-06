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

namespace Exercise4_GoToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int x = 10, y = 20;
            var foxDraw = new FoxDraw(canvas);
            GoToCenter(foxDraw, x, y);

        }

        public static void GoToCenter(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.BackgroundColor(Colors.Gray);
            foxDraw.StrokeColor(Colors.Green);
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(x, y, 300, 300);
                x *= 3;
                y *= 3;
                foxDraw.StrokeColor(Colors.Aquamarine);
            }
        }
    }
}
