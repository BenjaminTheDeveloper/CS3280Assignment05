using System;
using Xunit;
using StackOverFlowPost;

using System.Net.Http.Headers;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json.Linq;
using Xunit.Sdk;

namespace StackOverFlowPost.Tests
{
    public class PostTest
    {

        [Fact]

        public void Post_ChangeTitle_DifferentTitles()
        {
            var sut = new Post("Fake Post", "This is a fake post waiting to be changed", "Test");

            var actual = sut.Title;

                     
            var expected = sut.Title = "New Fake Post";

            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void Post_ChangeDescription_DifferentDescription()
        {
            var sut = new Post("Fake Post", "This is a fake post waiting to be changed", "Test");

            var actual = sut.Description;


            var expected = sut.Description = "This is no longer a fake posting waiting to be changed";

            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void Post_ChangeCreatedBy_DifferentCreatedBy()
        {
            var sut = new Post("Fake Post", "This is a fake post waiting to be changed", "Test");

            var actual = sut.CreatedBy;


            var expected = sut.CreatedBy = "Fake and Changed CreatedBy";

            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void Post_ChangeVoteCount_VoteUp()
        {
            var sut = new Post("Fake Title", "This is a fake description", "TestUser");
            sut.VoteUp();
            var expected = 1;
            var actual = sut.UpVoteCount;
            Assert.Equal(expected, actual);
         
        }
        [Fact]
        public void Post__ChangeVoteCount_VoteUp()
        {
            var sut = new Post("Fake Title", "This is a fake description", "TestUser");
            sut.VoteDown();
            var expected = 1; 
            var actual = sut.DownVoteCount;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Post_SetTitle_GetSameTitle()
        {
            var sut = new Post("Old Title", "Old title should be new title after change", "Test");
            sut.Title  = "New Title";

            var actual = sut.Title;
            var expected = "New Title";
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void Post_SetTitle_GetDifferentTitle()
        {
            var sut = new Post("Old Title", "Old title should be new title after change", "Test");
            sut.Title = "New Title";
            var actual = sut.Title;
            var expected = "Old Title";
            Assert.NotEqual(expected, actual);
        }


        [Fact]
        public void Post_ChangeCommentAmount_AddThreeComments()
        {
            var sut = new Post("Fake Title", "This was made to add comments", "Test");
            var testComment = new Comment("Test Comment", "Test");
            sut.AddComment(testComment);
            sut.AddComment(testComment);
            sut.AddComment(testComment);

            var actual = sut.getCommentTotal();
            var expected = 3;
            Assert.Equal(expected, actual);

        }
        //The following test cases are used for the Comment class. 
        [Fact]
        public void Comment_NewComment_ChangeDescription()
        {
            var sut = new Comment("Fake Desc", "Test");
            var actual = sut.Description;

            sut.Description = "Changed";
            var expected = sut.Description;

            Assert.NotEqual(expected, actual); 
        }

        public void Comment_NewComment_ChangeCreatedBy()
        {
            var sut = new Comment("Fake Desc", "Test");
            var actual = sut.CreatedBy;

            sut.CreatedBy = "Changed";
            var expected = sut.CreatedBy;

            Assert.NotEqual(expected, actual);
        }

        

    }
}
