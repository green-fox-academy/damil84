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

namespace Exercise5_Horizontal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int x = 50, y = 20;
            var foxDraw = new FoxDraw(canvas);
            Horizontal(foxDraw, x, y);
        }

        public static void Horizontal(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.BackgroundColor(Colors.LightGray);
            foxDraw.StrokeColor(Colors.Black);
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(x, y, x+50, y);
                x *= 2;
                y *= 2;
            }
        }
    }
}
