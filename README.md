# CS3280Assignment05
      Written By: Benjamin Medrano 
      
# Usage 
    This was written as a test output to emulate the same way a stack overflow post would result. 
    Without any of the UI the program is able to upvote, downvote, and add comments to a post. 
     
# Classes 

      All of the classes listed contain ways to change their variables and a constructor. 
      
      
      public class Post()
      {
            The Post class contains:
                title, 
                desciption,
                createdBy,
                upVoteCount,
                downVoteCount
      }
      
      public class Comment()
      {
      The Comment class contains:
                title, 
                desciption,
                createdBy    
      }

# Methods
        
        public void VoteDown() This method increases the down votes.

        public void VoteUp()   This method increases the up votes.

        public int getCommentTotal() This returns the total amount of comments in a post. 

        public void AddComment(Comment newComment) This adds a comments to the list of comments in a post.

        public void PrintComments() Prints out the comments that are contained in the post.
  
# Test 

    There is a total of nine tests. These tests were used to verify that both classes Post and Comment are able to be changed. 
    Things such as title, description, or who created the post or comment can be set to a different string. 
