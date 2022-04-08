using System.Diagnostics.CodeAnalysis;
using Hw3.Exercise3;
using Xunit;

namespace Hw3.Tests.Exercise3
{
    [SuppressMessage("Naming", "CA1707", MessageId = "Identifiers should not contain underscores")]
    public class MyAwesomeListTests
    {
        [Fact]
        public void MyAwesomeList_Tests()
        {
            var myAwesomeList = new MyAwesomeList<int>(10);

            myAwesomeList.Add(45);
            myAwesomeList.Add(100);
            Assert.Equal(2, myAwesomeList.Count);
            Assert.Equal(45, myAwesomeList.GetByIndex(0));
            Assert.Equal(100, myAwesomeList.GetByIndex(1));

            _ = myAwesomeList.DeleteAllElements();
            Assert.Equal(0, myAwesomeList.Count);

            myAwesomeList.Add(150);
            myAwesomeList.Add(160);
            myAwesomeList.Add(170);
            myAwesomeList.DeleteByIndex(0);
            Assert.Equal(2, myAwesomeList.Count);

            myAwesomeList.InsertAt(25, 0);
            Assert.Equal(25, myAwesomeList.GetByIndex(0));

            Assert.True(myAwesomeList.Contains(170));
            Assert.False(myAwesomeList.Contains(111));

            // NOTE: uncomment after implementing index & IEnumerator
            /*
            for (int i = 0; i < myAwesomeList.Count; i++)
            {
                Assert.Equal(myAwesomeList[i], myAwesomeList.GetByIndex(i));
            }
    
            foreach (var element in myAwesomeList)
            {
                Assert.True(element != 333);
            }
            */
        }
    }
}
