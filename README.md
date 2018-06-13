# ansiconsole
A very simple .NET ANSI Console Virtual Terminal Sequences

Based on [this link](https://docs.microsoft.com/en-us/windows/console/console-virtual-terminal-sequences#example)

```csharp
Console.WriteLine(@"Hi there in default color, %redHello \%red World in Red%end rest in %yellowyellow");
Console.WriteLine($"Hi there in default color, {AnsiCode.Foreground_Red____}Hello \\%red World in Red{AnsiCode.Default____} rest in %blueblue");
Console.WriteLine($"{AnsiCode.Bold____}{AnsiCode.Background_Yellow____}{AnsiCode.Foreground_Red____}Hello%reset");

//draw a rectangle
Console.Write($"{AnsiCode.Draw_NW____}");
Console.Repeat($"{AnsiCode.Draw_Horizontal____}", 10);
Console.WriteLine($"{AnsiCode.Draw_NE____}");
Console.Write($"{AnsiCode.Draw_Vertical____}");
Console.Write(new string(' ', 10));
Console.WriteLine($"{AnsiCode.Draw_Vertical____}");
Console.Write("%sw");
Console.Repeat($"{AnsiCode.Draw_Horizontal____}", 10);
Console.WriteLine("%se");

Console.WriteBlue("D");
Console.WriteRed("O");
Console.WriteGreen("N");
Console.WriteYellowLine("E");
Console.WriteBlueBackgroundLine("DONE");
Console.WriteBoldRedLine("Done");

![alt text](http://photos.wikimapia.org/p/00/02/54/57/56_big.jpg "Sample Output")
<img src='http://photos.wikimapia.org/p/00/02/54/57/56_big.jpg'/>
[test](http://photos.wikimapia.org/p/00/02/54/57/56_big.jpg)
