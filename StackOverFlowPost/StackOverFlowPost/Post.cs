using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowPost
{
    /// <summary class = "Post">
    /// Posts are used to discuss a topic
    /// The Post class was made to copy a stack over flow example. 
    /// You can create a post, change its title, change its description, and a user can comment on the post adding to the total amount.
    /// A Post can be upvoted and downvoted. 
    /// The methods were meant to be named as precisely as possible to match what they do. 
    /// </summary>
    public class Post
    {
        private string title, description, createdBy;
        private int downVoteCount, upVoteCount = 0;
        private DateTime dateCreated;
        List<Comment> Comments = new List<Comment> { };


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


        public int DownVoteCount { get { return downVoteCount; } }
        public int UpVoteCount { get { return upVoteCount; }}

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
            foreach (var comment in Comments)
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


}
