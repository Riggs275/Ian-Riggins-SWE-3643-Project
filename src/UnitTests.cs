namespace CalculatorEngineUnitTests;

public class Tests {

    [Test]
    public void Add_TwoFloatingPointValues_ReturnsSum() {
        //preq-UNIT-TEST-2
        
        //Arrange
        const double a = 5.5;
        const double b = -3.15;
        const double expected = 2.35;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Add(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Subtract_TwoFloatingPointValues_ReturnsDifference() {
        //preq-UNIT-TEST-3
        
        //Arrange
        const double a = 27.93;
        const double b = 4.01;
        const double expected = 23.92;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Subtract(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Multiplication_TwoFloatingPointValues_ReturnsProduct() {
        //preq-UNIT-TEST-4
        
        //Arrange
        const double a = 5.0;
        const double b = 7.1;
        const double expected = 35.5;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Multiplication(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Division_TwoFloatingPointValues_ReturnsQuotientOfValues() {
        //preq-UNIT-TEST-5
        
        //Arrange
        const double a = 3.0;
        const double b = 9.0;
        const double expected = 0.33333333;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Division(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
        //.Within(TestConstants.Percision)
    }

    [Test]
    public void Division_FloatingPointValueAndZero_ReturnsError() {
        //preq-UNIT-TEST-6
        
        //Arrange
        const double a = 300.275;
        const double b = 0;
        const bool expected = false;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Division(a, b);
        
        //Assert
        Assert.That(result.IsSuccess, Is.EqualTo(expected));
    }
    
    [Test]
    public void Equals_TwoFloatingPointValues_ReturnsFalse() {
        //preq-UNIT-TEST-7
        
        //Arrange
        const double a = 300.1000001;
        const double b = 300.1000000;
        const double expected = 0;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Equals(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Equals_TwoFloatingPointValues_ReturnsTrue() {
        //Arrange
        const double a = -275.55555559;
        const double b = -275.55555552;
        const double expected = 1;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Equals(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void RaiseToPower_TwoFloatingPointValues_ReturnsPower() {
        //preq-UNIT-TEST-8
        
        //Arrange
        const double a = 15.0;
        const double b = 2.0;
        const double expected = 225.0;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.RaiseToPower(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void LogarithmOfNumber_TwoFloatingPointValues_ReturnsLog() {
        //preq-UNIT-TEST-9
        
        //Arrange
        const double a = 225.00;
        const double b = 15.0;
        const double expected = 2.0;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.LogarithmOfNumber(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void LogarithmOfNumber_NegativeAndPositiveFloatingPointValues_ReturnsError() {
        //preq-UNIT-TEST-10
        
        //Arrange
        const double a = -225.00;
        const double b = 15.0;
        const bool expected = false;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.LogarithmOfNumber(a, b);
        
        //Assert
        Assert.That(result.IsSuccess, Is.EqualTo(expected));
    }
    
    [Test]
    public void LogarithmOfNumber_FloatingPointValueAndZero_ReturnsError() {
        //preq-UNIT-TEST-11
        
        //Arrange
        const double a = 300.275;
        const double b = 0;
        const bool expected = false;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.LogarithmOfNumber(a, b);
        
        //Assert
        Assert.That(result.IsSuccess, Is.EqualTo(expected));
    }
    
    [Test]
    public void Root_TwoFloatingPointValues_ReturnsRoot() {
        //preq-UNIT-TEST-12
        
        //Arrange
        const double a = 30517578125;
        const double b = 15.0;
        const double expected = 5.0;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.RootOfNumber(a, b);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Root_FloatingPointValueAndZero_ReturnsError() {
        //preq-UNIT-TEST-13
        
        //Arrange
        const double a = 17.18;
        const double b = 0;
        const bool expected = false;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.RootOfNumber(a, b);
        
        //Assert
        Assert.That(result.IsSuccess, Is.EqualTo(expected));
    }
    
    [Test]
    public void Factorial_Integer_ReturnsResult() {
        //preq-UNIT-TEST-14
        
        //Arrange
        const int a = 5;
        const int expected = 120;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.FactorialOfNumber(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Factorial_Zero_ReturnsOne() {
        //preq-UNIT-TEST-15
        
        //Arrange
        const int a = 0;
        const int expected = 1;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.FactorialOfNumber(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Factorial_Negative_ReturnsError() { 
        //Arrange
        const int a = -5;
        const bool expected = false;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.FactorialOfNumber(a);
        
        //Assert
        Assert.That(result.IsSuccess, Is.EqualTo(expected));
    }
    
    [Test]
    public void Sine_FloatingPointValue_ReturnsResult() {
        //preq-UNIT-TEST-16
        
        //Arrange
        const double a = 0;
        const double expected = 0;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Sine(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Cosine_FloatingPointValue_ReturnsResult() {
        //preq-UNIT-TEST-17
        
        //Arrange
        const double a = 0;
        const double expected = 1;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Cosine(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Tangent_FloatingPointValue_ReturnsResult() {
        //preq-UNIT-TEST-18
        
        //Arrange
        const double a = 45;
        const double expected = 1.6197751905438615;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.Tangent(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Reciprocal_FloatingPointValue_ReturnsResult() {
        //preq-UNIT-TEST-19
        
        //Arrange
        const double a = 0.5;
        const double expected = 2;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.ReciprocalOfNumber(a);
        
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Reciprocal_Zero_ReturnsError() {
        //preq-UNIT-TEST-20
        
        //Arrange
        const double a = 0.00;
        const bool expected = false;
        
        //Act
        var result = CalculatorEngine.CalculatorEngine.ReciprocalOfNumber(a);
        
        //Assert
        Assert.That(result.IsSuccess, Is.EqualTo(expected));
    }
}