namespace Android_CRUD_app
{
    class Secrets
    {
        public static string ApiKey = "12345-ABCDE-SECRET-KEY";
    }
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
