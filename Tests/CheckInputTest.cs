using Program;

namespace Tests
{
    [TestClass]
    public class CheckInputTest
    {
        [TestMethod]
        public void CheckTypeNumber_InputNumber_ReturnInput()
        {
            //Arrange
            string input = "3";
            double expected = 3;
            //Act
            double actual =  CheckInput.CheckTypeNumber(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckTypeNumber_InputNotNumber_ReturnError()
        {
            //Arrange
            string input = "a";
            //Act && Assert
            var expected = Assert.ThrowsException<ArgumentException>(()=>CheckInput.CheckTypeNumber(input));
            Assert.AreEqual("is not number", expected.Message);
        }
        [TestMethod]
        public void CheckTypeOperator_InputOperator_ReturnInput()
        {
            //Arrange
            string input = "+";
            //Act
            string actual =  CheckInput.CheckTypeOperator(input);
            //Assert
            Assert.AreEqual(input, actual);
        }
        [TestMethod]
        public void CheckTypeOperator_InputNotOperator_ReturnError()
        {
            //Arrange
            string input = "a";
            //Act && Assert
            var expected = Assert.ThrowsException<ArgumentException>(()=>CheckInput.CheckTypeOperator(input));
            Assert.AreEqual("is not operator", expected.Message);
        }
    }
}