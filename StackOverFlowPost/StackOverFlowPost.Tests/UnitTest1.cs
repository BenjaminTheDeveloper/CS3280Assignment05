using System;
using Xunit;
using StackOverFlowPost;


namespace StackOverFlowPost.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void getCommentTotal_ByAddingComment_IncreaseGetCommentTotal()
        {
            var sut = new Post("Title", "Desc", "Name"); 

        }
        [Fact]
        public void Post_AddComment_Null()
        {
            Assert.True(false);
        }
    }
}
