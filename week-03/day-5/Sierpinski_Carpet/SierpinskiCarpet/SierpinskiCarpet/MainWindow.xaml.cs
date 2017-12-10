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

namespace SierpinskiCarpet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawSquares(foxDraw, 0, 0, 560, 6);
        }

        static void DrawSquares(FoxDraw foxDraw, double startingX, double startingY, double size, int levels)
        {
            if (levels > 0)
            {
                foxDraw.FillColor(Colors.Black);
                foxDraw.DrawRectangle(startingX + (size / 3), startingY + (size / 3), size / 3, size / 3);

                DrawSquares(foxDraw, startingX, startingY, size / 3, levels - 1);
                DrawSquares(foxDraw, startingX + (size / 3), startingY, size / 3, levels - 1);
                DrawSquares(foxDraw, startingX, startingY + (size / 3), size / 3, levels - 1);
                DrawSquares(foxDraw, startingX, startingY + (size * 2 / 3), size / 3, levels - 1);
                DrawSquares(foxDraw, startingX + (size * 2 / 3), startingY, size / 3, levels - 1);
                DrawSquares(foxDraw, startingX + (size * 2 / 3), startingY + (size * 2 / 3), size / 3, levels - 1);
                DrawSquares(foxDraw, startingX + (size * 2 / 3), startingY + (size / 3), size / 3, levels - 1);
                DrawSquares(foxDraw, startingX + (size / 3), startingY + (size * 2 / 3), size / 3, levels - 1);
            }
        }
    }
}
