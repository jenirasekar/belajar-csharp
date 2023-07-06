namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what's your name?");
            string input = Console.ReadLine();
            Console.WriteLine($"your name is {input}");
        }
    }
}