namespace tests;

public class HealthCheckTests
{
    [Fact]
    public void Test1()
    {
        //arrange
        var data = new HealthCheckData(new Mass(100), new Height(100), new Age(10));
        
        //act
        var result = HealthCheck.CheckHealth(data);

        //assert
        var expected = new HealthCheckResult();
        Assert.Equal(expected, result);
    }
}