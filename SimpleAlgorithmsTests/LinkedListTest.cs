using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleAlgorithmsTests
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void Add()
        {
            // [given] empty linked list
            // [given] text value "x"
            var myList = new SimpleAlgorithms.LinkedList<string>();
            string myString = DateTime.Today.ToString();

            // [when] add the value "X"
            myList.Add(myString);

            // [then] Count is 1
            Assert.AreEqual(1, myList.Count);

            // [then] value is "X"
            var item = myList.GetEnumerator();
            item.MoveNext();
            Assert.AreEqual(myString, item.Current);
        }
        [TestMethod]
        public void Remove()
        {

        }
    }
}
