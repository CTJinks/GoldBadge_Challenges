using System;
using _07_RepoPattern__Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepoPattern_Tests
{
    [TestClass]
    public class ContentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            StreamingContent streamingContent = new StreamingContent();
            streamingContent.Title = "Freaked!";
            string expected = "Freaked!";
            string actual = streamingContent.Title;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FamilyFriendlyTest()
        {
            StreamingContent content = new StreamingContent();
            content.Title = "Mononoke";
            content.MaturityRating = MaturityRating.R;

            bool expected = false;
            bool actual = content.IsFamilyFriendly;

            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.PG_13, false)]
        [DataRow(MaturityRating.R, false)]
        [DataRow(MaturityRating.TV_MA, false)]
        public void SetMaturityRatingShouldGetCorrectIsFamilyFriendly(
            MaturityRating rating,
            bool expectedFamilyFriendly)
        {
            StreamingContent content = new StreamingContent();
            content.MaturityRating = rating;
            bool actual = content.IsFamilyFriendly;
            Assert.AreEqual(expectedFamilyFriendly, actual);
        }
    }
}
