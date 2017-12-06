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

namespace Exercise8_PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int x = 0, y = 0;
            var foxDraw = new FoxDraw(canvas);
            FourSquare(foxDraw, x, y);
        }

        public static void FourSquare(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.BackgroundColor(Colors.LightGray);
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawRectangle(x, y, 50, 50);
                x +=50;
                y +=50;
            }
        }
    }
}