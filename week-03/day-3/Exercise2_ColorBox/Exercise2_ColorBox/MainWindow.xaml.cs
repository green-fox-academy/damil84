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

namespace Exercise2_ColorBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawGreenLines(foxDraw);
        }

        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(50, 50, 550, 50);

            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(50, 550, 550, 550);

            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(50, 50, 50, 550);

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(550, 50, 550, 550);

        }
    }
}
