namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" 4 xonali sonni kiriting : ");
            var value = Convert.ToInt32(Console.ReadLine());
            var result = 0;
            for (var i = 0; i < 5; i++)
            {
                result += value % 10;
                value /= 10;
            }
            Console.WriteLine("Result " + result);
        }
    }
}
