using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Greenfox
{
    public class FoxDraw
    {
        private const int TileSize = 50;

        public Canvas Canvas { get; set; }
        private SolidColorBrush LineColor { get; set; } = SystemColors.WindowFrameBrush;
        private SolidColorBrush ShapeColor { get; set; } = new SolidColorBrush(Colors.DarkGreen);
        public List<Image> Tiles { get; set; }

        public FoxDraw(Canvas canvas)
        {
            Canvas = canvas;
            Tiles = new List<Image>();
        }

        public void DrawLine(Point p1, Point p2)
        {
            var line = new Line()
            {
                Stroke = LineColor,
                X1 = p1.X,
                Y1 = p1.Y,
                X2 = p2.X,
                Y2 = p2.Y
            };

            Canvas.Children.Add(line);
        }

        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            var line = new Line()
            {
                Stroke = LineColor,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };

            Canvas.Children.Add(line);
        }

        public void AddImage(string source, double x, double y)
        {
            var image = new Image()
            {
                Width = TileSize,
                Height = TileSize,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            Tiles.Add(image);
            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }

        public void AddImage(Canvas canvas, double x, double y)
        {
            Canvas.Children.Add(canvas);
            SetPosition(canvas, x, y);
        }

        public void SetPosition(UIElement uIElement, double x, double y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }

        public double GetLeft(UIElement uIElement)
        {
            return Canvas.GetLeft(uIElement);
        }

        public double GetTop(UIElement uIElement)
        {
            return Canvas.GetTop(uIElement);
        }

        public void ClearCanvas()
        {
            Canvas.Children.Clear();
        }
    }
}