using calculator;

namespace calculator.test
{
    [TestClass]
    public class CalulatorOperationTest
    {
        [TestMethod]
        public void AdditionTestSuccess()
        {
            var calculator = new CalculatorOperations();
            var result = calculator.Addition(1, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AdditionTestFailure()
        {
            var calculator = new CalculatorOperations();
            var result = calculator.Addition(3, 2);
            Assert.AreNotEqual(4, result);
        }

        [TestMethod]
        public void SubtractionTestSuccess()
        {
            var calculator = new CalculatorOperations();
            var result = calculator.Subtraction(2, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SubtractionTestFailure()
        {
            var calculator = new CalculatorOperations();
            var result = calculator.Subtraction(1, 1);
            Assert.AreNotEqual(1, result);
        }

        [TestMethod]
        public void MultiplicationTestSuccess()
        {
            var calculator = new CalculatorOperations();
            var result = calculator.Multiplication(2, 5);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void MultiplicationTestFailure()
        {
            var calculator = new CalculatorOperations();
            var result = calculator.Multiplication(2, 5);
            Assert.AreNotEqual(20, result);
        }

        [TestMethod]
        public void DivisionTestSuccess()
        {
            var calculator = new CalculatorOperations();
            var result = calculator.Division(6, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivisionTestFailure()
        {
            var calculator = new CalculatorOperations();
            var result = calculator.Division(0, 6);
            Assert.AreNotEqual(4, result);
        }
    }
}