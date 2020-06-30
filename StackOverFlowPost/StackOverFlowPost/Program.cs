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

            
            
            //Mock Post
            var post = new Post("Hello World", "This is the original program tradition", "Benjamin");


            // Adding comments to increase comment count and print out more
            post.AddComment(new Comment("I think everyone has done this, even if they don't code.", "Jordan"));
            post.AddComment(new Comment("Not true @Jordan", "James"));
            post.AddComment(new Comment("Idk it seems normal to have done a hello world. @James", "Becky"));

            //Adding to the posts vote count on both up and down votes. 
            post.VoteUp();
            post.VoteUp();
            post.VoteDown();
            post.VoteDown();

            //The ToString Method allows to print out the posts details
            //
           Console.WriteLine(post.ToString());
           Console.WriteLine("Comment Total: " + post.getCommentTotal());

        //Prints the comments out one by one
        //
           post.PrintComments();

         
            Console.ReadKey(); 
        }
    }
}
