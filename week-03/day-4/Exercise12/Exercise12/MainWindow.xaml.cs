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

namespace Exercise12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawHexagonal(foxDraw, 0, 0, 500, 5);
        }

        static void DrawHexagonal(FoxDraw foxDraw, double startingX, double startingY, double size, int levels)
        {
            if (levels > 0)
            {
                foxDraw.StrokeColor(Colors.Black);
                foxDraw.DrawLine(startingX + (size / 4), startingY, startingX + (size * 3 /4), startingY);
                foxDraw.DrawLine(startingX + (size / 4), startingY, startingX, startingY + (size / 2));
                foxDraw.DrawLine(startingX, startingY + (size / 2), startingX + (size / 4), startingY + size);
                foxDraw.DrawLine(startingX + (size / 4), startingY + size, startingX + (size * 3 / 4), startingY + size);
                foxDraw.DrawLine(startingX + (size * 3 / 4), startingY + size, startingX + size, startingY + (size / 2));
                foxDraw.DrawLine(startingX + size, startingY + (size / 2), startingX + (size * 3 / 4), startingY);

                DrawHexagonal(foxDraw, startingX + (size /8), startingY, (size / 2), levels - 1);
                DrawHexagonal(foxDraw, startingX + (size / 8), startingY + (size / 2), size / 2, levels - 1);
                DrawHexagonal(foxDraw, startingX + (size / 2), startingY + (size /4), size / 2, levels - 1);
            }
        }
    }
}
