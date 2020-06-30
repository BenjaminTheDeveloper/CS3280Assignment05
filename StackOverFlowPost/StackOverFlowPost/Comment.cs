using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowPost
{

    /// <summary class = "Comment">
    /// The comment class is used to create a comment that has a description, a user, and a date it was created. 
    /// A new comment can be added to a post or created separately.
    /// </summary>
    public class Comment
    {

        private string description, createdBy;
        private DateTime dateCreated;



        public Comment(string commentDescription, string commentCreatedBy)
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
