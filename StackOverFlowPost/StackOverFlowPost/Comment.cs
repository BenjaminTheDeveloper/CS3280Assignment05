using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowPost
{
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
