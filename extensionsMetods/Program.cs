

using extensionsMetods.Extensions;
using extensionsMetods.Services;
namespace extensionsMetods
{
    delegate double deleg(double x, double y);
    public class MyClass
    {

        public static void Main(string[] args)
        {

            //2ºparte
            double x = 10;
            double y = 20;
            double max = CalcServices.Max(x, y);
            double min = CalcServices.Min(x, y);
            double sum = CalcServices.Sum(x, y);
            double sub = CalcServices.Sub(x, y);

            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Sub: {sub}");

            deleg d = CalcServices.Sum;
            Console.WriteLine($"Delegate Max: {d(x, y)}");

            //1ºparte
            DateTime dt = new DateTime(2023, 10, 1, 12, 0, 0);
            Console.WriteLine(dt.ElapedTime());
        }

}
}