using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StackOverFlow Post");

            var post = new Post("Hello World", "This is the original program tradition", "Benjamin");

            post.AddComment(new Comment("I think everyone has done this, even if they don't code.", "Jordan"));
            post.AddComment(new Comment("Not true @Jordan", "James"));
            post.AddComment(new Comment("Idk it seems normal to have done a hello world. @James", "Becky"));

            post.VoteUp();
            post.VoteUp();
            post.VoteDown();
            post.VoteDown();


           Console.WriteLine(post.ToString());
           Console.WriteLine("Comment Total: " + post.getCommentTotal());
           post.PrintComments();

         
            Console.ReadKey(); 
        }
    }
}
