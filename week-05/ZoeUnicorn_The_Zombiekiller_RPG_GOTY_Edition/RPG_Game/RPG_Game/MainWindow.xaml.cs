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
using Greenfox;

namespace RPG_Game
{
    public partial class MainWindow : Window
    {
        public FoxDraw foxDraw;
        public FoxDraw foxDrawHero;
        public Map mymap;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            foxDrawHero = new FoxDraw(canvas);
            mymap = new Map(foxDraw);
            mymap.MapCreater();
            foxDrawHero.AddImage("./Assets/zoe.png", 0, 0);
        }

        private new void KeyDownEvent(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.Right)
            {

                if (mymap.tilelist[listcounter] == 0)
                {

                }

                foxDrawHero.Tiles[0].Source = new BitmapImage(new Uri("./Assets/zoeRight.png", UriKind.Relative));
                double x = foxDrawHero.GetLeft(foxDrawHero.Tiles[0]) + 50;
                double y = foxDrawHero.GetTop(foxDrawHero.Tiles[0]);
                foxDrawHero.SetPosition(foxDrawHero.Tiles[0], x, y);

            }

            if (e.Key == Key.Down)
            {
                double x = foxDrawHero.GetLeft(foxDrawHero.Tiles[0]);
                double y = foxDrawHero.GetTop(foxDrawHero.Tiles[0]) + 50;
                foxDrawHero.Tiles[0].Source = new BitmapImage(new Uri("./Assets/zoe.png", UriKind.Relative));
                foxDrawHero.SetPosition(foxDrawHero.Tiles[0], x, y);
            }

            if (e.Key == Key.Up)
            {
                double x = foxDrawHero.GetLeft(foxDrawHero.Tiles[0]);
                double y = foxDrawHero.GetTop(foxDrawHero.Tiles[0]) - 50;
                foxDrawHero.Tiles[0].Source = new BitmapImage(new Uri("./Assets/zoeBack.png", UriKind.Relative));
                foxDrawHero.SetPosition(foxDrawHero.Tiles[0], x, y);
            }

            if (e.Key == Key.Left)
            {
                double x = foxDrawHero.GetLeft(foxDrawHero.Tiles[0]) - 50;
                double y = foxDrawHero.GetTop(foxDrawHero.Tiles[0]);
                foxDrawHero.Tiles[0].Source = new BitmapImage(new Uri("./Assets/zoeLeft.png", UriKind.Relative));
                foxDrawHero.SetPosition(foxDrawHero.Tiles[0], x, y);
            }
        }
    }
}

