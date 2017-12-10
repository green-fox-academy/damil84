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

namespace Exercise_11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLinesEx11(foxDraw, 0, 0, 560, 5);
        }

        static void DrawLinesEx11(FoxDraw foxDraw, double startingX, double startingY, double size, int levels)
        {
            if (levels > 0)
            {
                foxDraw.BackgroundColor(Colors.Yellow);
                foxDraw.StrokeColor(Colors.Black);
                foxDraw.DrawLine(startingX + (size/3), startingY, startingX + (size /3), startingY + size);
                foxDraw.DrawLine(startingX + (size *2/3), startingY, startingX + (size *2 / 3), startingY + size);
                foxDraw.DrawLine(startingX, startingY + (size /3), startingX + size, startingY + (size /3));
                foxDraw.DrawLine(startingX, startingY + (size *2 / 3), startingX + size, startingY + (size * 2/ 3));

                DrawLinesEx11(foxDraw, startingX + (size /3), startingY, size / 3, levels - 1);
                DrawLinesEx11(foxDraw, startingX, startingY + (size / 3), size / 3, levels - 1);
                DrawLinesEx11(foxDraw, startingX + (size / 3), startingY + (size * 2 /3), (size / 3), levels - 1);
                DrawLinesEx11(foxDraw, startingX + (size * 2 / 3), startingY + (size / 3), (size / 3), levels - 1);
            }
        }
    }
}
