namespace Calculator.tests
{
    // BDD or GWT
    public class CalculatorTest
    {
        [Fact(DisplayName = "Given valid numbers, When sum then should success.")]
        public void GivenValidNumbers_WhenSum_ThenShouldSuccess()
        {
            // arrange
            const int firstNumber = 5;
            const int secondNumber = 10;
            const int resultExpected = 15;

            // act
            var resultActual = Calculator.Sum(firstNumber, secondNumber);

            // assert
            Assert.Equal(resultExpected, resultActual);
        }

        [Fact(DisplayName = "Given invalid numbers, When sum then should error.")]
        public void GivenInvalidNumbers_WhenSum_ThenShouldError()
        {
            // arrange
            const double firstNumber = 5.2;
            const int secondNumber = 10;
            const int resultExpected = 15;

            // act
            var resultActual = Calculator.Sum(firstNumber, secondNumber);

            // assert
            Assert.NotEqual(resultExpected, resultActual);
        }

        [Fact(DisplayName = "Given valid numbers, when divider then should success")]
        public void GivenValidNumbers_WhenDivider_ThenShouldSuccess()
        {
            // arrange
            const double firstNumber = 30;
            const int secondNumber = 2;
            const int resultExpected = 15;

            // act
            var resultActual = Calculator.Div(firstNumber, secondNumber);

            // assert
            Assert.Equal(resultExpected, resultActual);
        }

        [Fact(DisplayName = "Given invalid numbers, when divider then should error")]
        public void GivenInvalidNumbers_WhenDivider_ThenShouldError()
        {
            // arrange
            const double firstNumber = 20;
            const int secondNumber = 2;
            const int resultExpected = 15;

            // act
            var resultActual = Calculator.Div(firstNumber, secondNumber);

            // assert
            Assert.NotEqual(resultExpected, resultActual);
        }

        [Fact(DisplayName = "Given valid numbers, when multiplacate then should success")]
        public void GivenValidNumbers_WhenMultiplicate_ThenShouldSuccess()
        {
            // arrange
            const double firstNumber = 10;
            const int secondNumber = 2;
            const int resultExpected = 20;

            // act
            var resultActual = Calculator.Mul(firstNumber, secondNumber);

            // assert
            Assert.Equal(resultExpected, resultActual);
        }

        [Fact(DisplayName = "Given invalid numbers, when multiplicate then should error")]
        public void GivenInvalidNumbers_WhenMultiplicate_ThenShouldError()
        {
            // arrange
            const double firstNumber = 20;
            const int secondNumber = 2;
            const int resultExpected = 15;

            // act
            var resultActual = Calculator.Mul(firstNumber, secondNumber);

            // assert
            Assert.NotEqual(resultExpected, resultActual);
        }

        [Fact(DisplayName = "Given valid numbers, when subtracting then should success")]
        public void GivenValidNumbers_WhenSubtracting_ThenShouldSuccess()
        {
            // arrange
            const double firstNumber = 30;
            const int secondNumber = 10;
            const int resultExpected = 20;

            // act
            var resultActual = Calculator.Sub(firstNumber, secondNumber);

            // assert
            Assert.Equal(resultExpected, resultActual);
        }

        [Fact(DisplayName = "Given invalid numbers, when subtracting then should error")]
        public void GivenInvalidNumbers_WhenSubtracting_ThenShouldError()
        {
            // arrange
            const double firstNumber = 20;
            const int secondNumber = 2;
            const int resultExpected = 15;

            // act
            var resultActual = Calculator.Sub(firstNumber, secondNumber);

            // assert
            Assert.NotEqual(resultExpected, resultActual);
        }
    }
}