
using Tyuiu.MikhailovVN.Sprint0.Task6.V0.Lib;
namespace Tyuiu.MikhailovVN.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayhnums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arrayhnums));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(arrayhnums));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arrayhnums));

            Console.ReadKey();
        }
    }
}
