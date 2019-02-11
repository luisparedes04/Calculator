using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_Success()
        {
            Calculator c1 = new Calculator();
            Assert.AreEqual(c1.CurrentValue, 0);
        }
        // Basic Methods Tests

        // Addition Method Test
        [TestMethod]
        public void Add_success()
        {
            Calculator c1 = new Calculator();
            c1.Add(10m);
            Assert.AreEqual(c1.CurrentValue, 10);
        }
        // Substraction Method Test
        [TestMethod]
        public void Substraction_success()
        {
            Calculator c1 = new Calculator();
            c1.Substract(10m);
            Assert.AreEqual(c1.CurrentValue, 10);
        }
        // Multiplication Method Test
        [TestMethod]
        public void Multiply_Success()
        {
            Calculator c1 = new Calculator();
            c1.Multiply(10m);
            Assert.AreEqual(c1.CurrentValue, 10);
        }
        // Multiplication Method Test 2
        [TestMethod]
        public void Multiply1_Success()
        {
            Calculator c1 = new Calculator();
            c1.Multiply(5m);
            c1.Multiply(5m);
            Assert.AreEqual(c1.CurrentValue, 25);
        }
        // Division Method Test
        [TestMethod]
        public void Divide_Success()
        {
            Calculator c1 = new Calculator();
            c1.Divide(10m);
            Assert.AreEqual(c1.CurrentValue, 10);
        }
        [TestMethod]
        public void Divide1_Success()
        {
            Calculator c1 = new Calculator();
            c1.Add(10m);
            c1.Equals(5);
            c1.Divide(5);

            Assert.AreEqual(c1.CurrentValue, 3);
        }
        // End of basic methods tests
        // Equal Method Tests (when NO parameter is passed). Using Add, Substract, Multiply and Divide methods
        [TestMethod]
        public void EqualAdd_Success()
        {
            Calculator c1 = new Calculator();
            c1.Add(2);
            c1.Equals();
            Assert.AreEqual(c1.CurrentValue, 4);
        }
        [TestMethod]
        public void EqualSubstract_Success()
        {
            Calculator c1 = new Calculator();
            c1.Substract(3);
            c1.Equals();
            Assert.AreEqual(c1.CurrentValue, 0);
        }
        [TestMethod]
        public void EqualMultiply_Success()
        {
            Calculator c1 = new Calculator();
            c1.Multiply(2);
            c1.Equals();
            Assert.AreEqual(c1.CurrentValue, 4);
        }
        [TestMethod]
        public void EqualDivide_Success()
        {
            Calculator c1 = new Calculator();
            c1.Divide(2);
            c1.Equals();
            Assert.AreEqual(c1.CurrentValue, 1);
        }
        // End of equal method tests

        // Equals Method Tests (when a parameter is passed). Using Add, Substract, Multiply and Divide methods
        [TestMethod]
        public void EqualsAdd_Success()
        {
            Calculator c1 = new Calculator();
            c1.Add(2);
            c1.Equals(3);
            Assert.AreEqual(c1.CurrentValue, 5);
        }
        [TestMethod]
        public void EqualsSubstract_Success()
        {
            Calculator c1 = new Calculator();
            c1.Substract(2);
            c1.Equals(1);
            Assert.AreEqual(c1.CurrentValue, 1);
        }
        [TestMethod]
        public void EqualsMultiply_Success()
        {
            Calculator c1 = new Calculator();
            c1.Multiply(2);
            c1.Equals(3);
            Assert.AreEqual(c1.CurrentValue, 6);
        }
        [TestMethod]
        public void EqualsDivide_Success()
        {
            Calculator c1 = new Calculator();
            c1.Divide(10);
            c1.Equals(2);
            Assert.AreEqual(c1.CurrentValue, 5);
        }
        // End of Equals methods

        // Division by zero, expecting an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Divide_Failure()
        {
            Calculator c1 = new Calculator();
            c1.Divide(5);
            c1.Equals(0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Divide_Failure1()
        {
            Calculator c1 = new Calculator();
            c1.Divide(0);
            c1.Equals();
        }

        //Clear Method Test
        [TestMethod]
        public void Clear_Success()
        {
            Calculator c1 = new Calculator();
            c1.Add(2);
            c1.Equals(3);
            c1.Clear();
            Assert.AreEqual(c1.CurrentValue, 0);
        }

        // Memory Tests

        // Memory Store Test
        [TestMethod]
        public void MemoryStore_Success()
        {
            MemoryCalculator m1 = new MemoryCalculator();
            m1.MemoryStore(5);
            Assert.AreEqual(m1.MemoryValue, 5);
        }
        // Memory Add Test
        [TestMethod]
        public void MemoryAdd_Success()
        {
            MemoryCalculator m1 = new MemoryCalculator();
            m1.MemoryStore(5);
            m1.MemoryAdd(3);
            Assert.AreEqual(m1.MemoryValue, 8);
        }
        // Memory Recall Test
        [TestMethod]
        public void MemoryRecall_Success()
        {
            MemoryCalculator m1 = new MemoryCalculator();
            m1.MemoryStore(5);
            m1.MemoryRecall();
            Assert.AreEqual(m1.MemoryValue, 5);
        }
        //Memory Clear Test
        [TestMethod]
        public void MemoryClear_Success()
        {
            MemoryCalculator m1 = new MemoryCalculator();
            m1.MemoryStore(5);
            m1.MemoryClear();
            Assert.AreEqual(m1.MemoryValue, 0);
        }
    }
}
