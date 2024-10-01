using Program;
 
namespace Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calculator_Add_ReturnExerciseWithSolution()
        {
            //Arrange
            double num1 = 3;
            double num2 = 5;
            string oper = "+";
            string expected = "3 + 5 = 8";
            //Act
            string actual =  Calculator.Calculate(num1, num2, oper);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculator_Reduce_ReturnExerciseWithSolution()
        {
            //Arrange
            double num1 = 10;
            double num2 = 4;
            string oper = "-";
            string expected = "10 - 4 = 6";
            //Act
            string actual =  Calculator.Calculate(num1, num2, oper);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculator_Multiply_ReturnExerciseWithSolution()
        {
            //Arrange
            double num1 = 3;
            double num2 = 5;
            string oper = "*";
            string expected = "3 * 5 = 15";
            //Act
            string actual =  Calculator.Calculate(num1, num2, oper);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculator_Divide_ReturnExerciseWithSolution()
        {
            //Arrange
            double num1 = 10;
            double num2 = 5;
            string oper = "/";
            string expected = "10 / 5 = 2";
            //Act
            string actual =  Calculator.Calculate(num1, num2, oper);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculator_DivideByZero_ThrowError()
        {
            //Arrange
            double num1 = 10;
            double num2 = 0;
            string oper = "/";
            //Act && Assert
            var expected = Assert.ThrowsException<ArgumentException>(()=>Calculator.Calculate(num1, num2, oper));
            Assert.AreEqual("Cannot divide by zero", expected.Message);
        }
    }
}
    