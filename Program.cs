using LittleMoon.AnsiConsole;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Hi there in black, %redHello \%red World in Red%end rest in %blackblack");
        Console.WriteLine($"Hi there in black, {AnsiCode.Foreground_Red____}Hello \\%red World in Red{AnsiCode.Default____} rest in %blueblue");
        Console.WriteLine($"{AnsiCode.Bold____}{AnsiCode.Background_Yellow____}{AnsiCode.Foreground_Red____}Hello%reset \u001b(0j\u001b(B");
    }
}