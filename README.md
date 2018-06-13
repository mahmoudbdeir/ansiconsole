# ansiconsole
A very simple .NET ANSI Console Virtual Terminal Sequences

Based on [this link](https://docs.microsoft.com/en-us/windows/console/console-virtual-terminal-sequences#example)

```csharp
Console.WriteLine(@"Hi there in default color, %redHello \%red World in Red%end rest in %yellowyellow");
```
Hi there in default color, <span style='color:red'>%redHello \%red World in Red%end rest in </span><span style='color:yellow'>yellow</span>
Console.WriteLine($"Hi there in default color, {AnsiCode.Foreground_Red____}Hello \\%red World in Red{AnsiCode.Default____} rest in %blueblue");

Console.WriteLine($"{AnsiCode.Bold____}{AnsiCode.Background_Yellow____}{AnsiCode.Foreground_Red____}Hello%reset");

#Sample Output
![sample output](https://github.com/mbdeir/ansiconsole/blob/master/sampleoutput.png "Sample Output")
