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



    public class Post
    {
        private string title, description, createdBy;
        private int downVoteCount, upVoteCount = 0;
        private DateTime dateCreated;
        List<Comment> Comments = new List<Comment> {};


        public Post(string postTitle, string postDescription, string postCreatedBy)
        {
            title = postTitle;

            description = postDescription;

            createdBy = postCreatedBy;

            dateCreated = DateTime.Now;

            downVoteCount = 0;

            upVoteCount = 0; 
        }


        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }


        public int DownVoteCount { get;  }
        public int UpVoteCount { get; }

        public void VoteDown()
        {
            downVoteCount++; 
        }
       
        public void VoteUp()
        {
            upVoteCount++;
        }
        

        public int getCommentTotal()
        {
            return Comments.Capacity - 1; 
        }
        public void AddComment(Comment newComment)
        {
            Comments.Add(newComment);
        }

        public void PrintComments()
        {
            foreach(var comment in Comments)
            {
                Console.WriteLine(comment.ToString());
            }
        }

        public override string ToString()
        {
            return "Title: " + title + " \nDescription: " + description 
                + "\n Created By: "
                + createdBy + " Up votes: " + upVoteCount + " Down votes: " + downVoteCount + " \n " + "\n" + dateCreated; 


        }
    }

    public class Comment
    {

        private string description, createdBy;
        private DateTime dateCreated; 
        


        public Comment( string commentDescription, string commentCreatedBy)
        {
            description = commentDescription;
            createdBy = commentCreatedBy;
            dateCreated = DateTime.Now;
        }

        public string Description { get; set; }
        public string CreatedBy { get; set; }

        public DateTime DateCreated { get; }


        public override string ToString()
        {
            return " \nDescription: " + description
                + "\n Created By: "
                + createdBy + "\n" + dateCreated; 


        }
    }
}
