namespace FoundationalCsWithMsCertification
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int farenheit = 94;
			decimal convertToCelsius = (farenheit - 32) * (5.0m / 9); 
			Console.WriteLine($"{convertToCelsius} Celsius");

		}
	}
}
