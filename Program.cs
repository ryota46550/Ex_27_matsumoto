using InputUtilitys;
namespace Ex_2022_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = InputUtility.Input("Name:");
            Console.WriteLine($"Hello {name}!");
        }
    }
}