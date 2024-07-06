namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double f = 32;
            double c = 32;
            double k = 32;

            Console.WriteLine($"{f}F = {TempConverter.FahrenheitToCelsius(f)}F");
            Console.WriteLine($"{c}C = {TempConverter.CelsiusToFahrenheit(c)}F");
            Console.WriteLine($"{f}F = {TempConverter.FahrenheitToKelvin(f)}K");
            Console.WriteLine($"{c}C = {TempConverter.CelsiusToKelvin(c)}K");
            Console.WriteLine($"{k}K = {TempConverter.KelvinToFahrenheit(k)}F");
            Console.WriteLine($"{k}K = {TempConverter.KelvinToCelsius(k)}C");
        }
    }
}
