namespace CSharp.Playground.CSharp2.Tests.Generics
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CSharp.Playground.CSharp2.Generics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GenericValueTypeStackTests
    {
        [TestMethod]
        public void StackIsFirstInLastOut()
        {
            var size = 42;
            var stack = new GenericValueTypeStack<int>(size);

            for (int i = 0; i < size; i++)
            {
                stack.Push(i);
            }

            for (int i = size - 1; i >= 0; i--)
            {
                Assert.AreEqual(i, stack.Pop());
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SizeZero_ThrowsArgumentOutOfRangeException()
        {
            var stack = new GenericValueTypeStack<int>(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SizeLessThanZero_ThrowsArgumentOutOfRangeException()
        {
            var stack = new GenericValueTypeStack<int>(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PoppingEmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new GenericValueTypeStack<int>(1);

            stack.Pop();
            stack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PushingFullStack_ThrowsInvalidOperationException()
        {
            var stack = new GenericValueTypeStack<int>(1);

            stack.Push(0);
            stack.Push(1);
        }
    }
}
