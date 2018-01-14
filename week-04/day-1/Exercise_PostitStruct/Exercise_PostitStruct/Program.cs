using System;

namespace Exercise_PostitStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var postit = new Postit();
            var postit1 = new Postit();
            var postit2 = new Postit();
            postit.BackgrounColor = "orange";
            postit.Text = "idea1";
            postit.TextColor = "Blue";

            postit1.BackgrounColor = "pink";
            postit1.Text = "Awesome";
            postit1.TextColor = "Black";

            postit2.BackgrounColor = "yellow";
            postit2.Text = "super";
            postit2.TextColor = "green";
        }
    }
}