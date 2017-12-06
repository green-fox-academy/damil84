﻿using System;
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

namespace Exercise11_PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int x = 10, y = 10;
            var foxDraw = new FoxDraw(canvas);
            FourSquare(foxDraw, x, y);
        }

        public static void FourSquare(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.BackgroundColor(Colors.LightGray);
            foxDraw.FillColor(Colors.Purple);
            var random = new Random();
            for (int i = 0; i < 19; i++)
            {
                foxDraw.DrawRectangle(x, y, 10, 10);
                x = (x + 10);
                y = (y + 10);
            }
        }
    }
}