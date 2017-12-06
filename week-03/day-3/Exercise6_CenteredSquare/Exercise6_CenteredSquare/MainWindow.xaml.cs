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

namespace Exercise6_CenteredSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            CenteredSqare(foxDraw);
            foxDraw.BackgroundColor(Colors.LightGray);
        }

        public static void CenteredSqare(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawRectangle(245, 245, 10, 10);
        }
    }

}
