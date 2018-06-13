# ansiconsole
A very simple .NET ANSI Console Virtual Terminal Sequences

Based on [this link](https://docs.microsoft.com/en-us/windows/console/console-virtual-terminal-sequences#example)

```csharp
Console.WriteLine(@"Hi there in black, %redHello \%red World in Red%end rest in %blackblack");
Hi there in black, <span style="color:red">Hello %red World in Red</span> rest in black

Console.WriteLine($"Hi there in black, {AnsiCode.Foreground_Red____}Hello \\%red World in Red{AnsiCode.Default____} rest in %blueblue");
Hi there in black, <span style="color:red">Hello %red World in Red</span> rest in <span style="color:blue">blue</span>

Console.WriteLine($"{AnsiCode.Bold____}{AnsiCode.Background_Yellow____}{AnsiCode.Foreground_Red____}Hello%reset \u001b(0j\u001b(B");
