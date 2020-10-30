using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System;

namespace SortingEx.Test
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void Text_Sort_Success_Test()
        {
            var text = "Contrary to popular belief, the pink unicorn flies east.";
            var expectedResponse = "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy";

            var mockRepo = new MockRepository();
            var mockSort = mockRepo.DynamicMock<ISort>();

            mockSort.Expect(s => s.SortText(text)).Return(expectedResponse);

            var sort = new Sort();
            var actualResponse = sort.SortText(text);

            Assert.AreEqual(expectedResponse, actualResponse);
        }
        [TestMethod]
        public void Text_Sort_ExceptionMessage_Test()
        {
            var text = "";
            var expectedResponse = "The text must not be empty.";

            var mockRepo = new MockRepository();
            var mockSort = mockRepo.DynamicMock<ISort>();

            mockSort.Expect(s => s.SortText(text)).Return(expectedResponse);

            var sort = new Sort();
            var actualResponse = sort.SortText(text);

            Assert.AreEqual(expectedResponse, actualResponse);
        }
    }
}
