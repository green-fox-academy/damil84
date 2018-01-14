using System;

namespace Exercise_PostitStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var blog = new Postit();
            blog.AuthorName = "John Doe";
            blog.Title = "Lorem ipsum";
            blog.Text = "Lorem ipsum dolor sit amet.";
            blog.PublicationDate = "2000.05.04.";
            Console.WriteLine("Blog 0=> Author: {0}, Title: {1}, Publication date: {2}", blog.AuthorName, blog.Title, blog.PublicationDate);
            Console.WriteLine("Brief text: " + blog.Text);
            Console.WriteLine();

            var blog1 = new Postit();
            blog1.AuthorName = "Tim Urban";
            blog1.Title = "Wait but why";
            blog1.Text = "A popular long-form, stick-figure-illustrated blog about almost everything";
            blog1.PublicationDate = "2010.10.10.";
            Console.WriteLine("Blog 1=> Author: {0}, Title: {1}, Publication date: {2}", blog1.AuthorName, blog1.Title, blog1.PublicationDate);
            Console.WriteLine("Brief text: " + blog1.Text);
            Console.WriteLine();

            var blog2 = new Postit();
            blog2.AuthorName = "William Turton ";
            blog2.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blog2.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center " +
                "of attention. When I asked to take his picture outside one of IBM’s New York City offices," +
                " he told me that he wasn’t really into the whole organizer profile thing.";
            blog2.PublicationDate = " 2017.03.28.";
            Console.WriteLine("Blog 2=> Author: {0}, Title: {1}, Publication date: {2}", blog2.AuthorName, blog2.Title, blog2.PublicationDate);
            Console.WriteLine("Brief text: " + blog2.Text);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}