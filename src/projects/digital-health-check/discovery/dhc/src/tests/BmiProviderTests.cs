namespace tests;

public class BmiProviderTests
{

    [Fact]
    public void TestBmi()
    {
        //arrange
        var mass = new Mass(100000);
        var height = new Height(180);
        var consoleLogger = LoggerFactory.Create(loggingBuilder => loggingBuilder
            .AddConsole()
            .AddDebug()
            .SetMinimumLevel(LogLevel.Trace));
            
        var logger = consoleLogger.CreateLogger<BmiCalculatorProvider>();
        var calculator = new BmiCalculatorProvider(logger);
        //act
        var bmi = calculator.CalculateBmi(height, mass);

        //assert
        var result = bmi.Value;
        var expected =  30.9f;

        Assert.Equal(expected, result);
    }     
}