namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double result = TempConverter.CelsiusToFahreinheit(10);

            Console.WriteLine("Conversion Result ");
            Console.WriteLine($"Celsius 10 = {result} Farenheit ");

            result = TempConverter.FahrenheitToCelsius(20);

            Console.WriteLine($"Fahrenheit 20 = {result} Celsius ");

            result = TempConverter.CelsiusToFahreinheit(result);
            Console.WriteLine($" Which is {result} Farenheit");
        }
        
    }
}
