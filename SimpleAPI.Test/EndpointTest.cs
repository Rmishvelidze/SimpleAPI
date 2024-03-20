using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class EndpointTest
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void CityQuantity_Should_Be_AnInteger()
    {
        var quantity = controller.GetCityQuantity();
        Assert.IsType<int>(quantity);
    }
}