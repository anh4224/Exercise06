using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPush()
        {
            MyStack S = new MyStack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual(3, S.Count());
        }
        [TestMethod]
        public void TestPop()
        {
            MyStack S = new MyStack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Pop());
            Assert.AreEqual("2", S.Pop());
        }
        [TestMethod]
        public void TestPeek()
        {
            MyStack S = new MyStack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Peek());
            Assert.AreEqual(3, S.Count());
        }
        [TestMethod]
        public void TestClear()
        {
            MyStack S = new MyStack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            S.Clear();
            Assert.AreEqual(0, S.Count());
        }
    }
}
