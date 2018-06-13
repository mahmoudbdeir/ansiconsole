using System;
using System.Runtime.InteropServices;

namespace LittleMoon.AnsiConsole
{
    public static class Console
    {
        #region Windows API 
        private const int STD_OUTPUT_HANDLE = -11;
        private const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;
        private const uint DISABLE_NEWLINE_AUTO_RETURN = 0x0008;

        [DllImport("kernel32.dll")]
        private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        private static extern uint GetLastError();
        #endregion

        #region static constructor
        static Console()
        {
            var iStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
            if (!GetConsoleMode(iStdOut, out uint outConsoleMode))
            {
                System.Console.WriteLine("failed to get output console mode");
                System.Console.ReadKey();
                return;
            }

            outConsoleMode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING | DISABLE_NEWLINE_AUTO_RETURN;
            if (!SetConsoleMode(iStdOut, outConsoleMode))
            {
                System.Console.WriteLine($"failed to set output console mode, error code: {GetLastError()}");
                System.Console.ReadKey();
                return;
            }
        }
        #endregion

        public static void Repeat(string s, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Write(s);
            }
        }
        public static void WriteLine(string s)
        {
            Write(s);
            System.Console.WriteLine();
        }
        public static void ResetBackground(string s)
        {
            Write($"%breset{s}%reset");
        }

        #region Fore Color
        public static void WriteBlue(string s)
        {
            Write($"%blue{s}%reset");
        }
        public static void WriteRed(string s)
        {
            Write($"%red{s}%reset");
        }

        public static void WriteGreen(string s)
        {
            Write($"%green{s}%reset");
        }

        public static void WriteYellow(string s)
        {
            Write($"%yellow{s}%reset");
        }

        public static void WriteMagenta(string s)
        {
            Write($"%magenta{s}%reset");
        }

        public static void WriteCyan(string s)
        {
            Write($"%cyan{s}%reset");
        }

        public static void WriteWhite(string s)
        {
            Write($"%white{s}%reset");
        }
        public static void WriteBlueLine(string s)
        {
            WriteBlue(s + "\n\r");
        }
        public static void WriteRedLine(string s)
        {
            WriteRed(s + "\n\r");
        }

        public static void WriteGreenLine(string s)
        {
            WriteGreen(s + "\n\r");
        }

        public static void WriteYellowLine(string s)
        {
            WriteYellow(s + "\n\r");
        }

        public static void WriteMagentaLine(string s)
        {
            WriteMagenta(s + "\n\r");
        }

        public static void WriteCyanLine(string s)
        {
            WriteCyan(s + "\n\r");
        }

        public static void WriteWhiteLine(string s)
        {
            WriteWhite(s + "\n\r");
        }
        #endregion

        #region Background Color
        public static void WriteBlackBackground(string s)
        {
            Write($"%bblack{s}%reset");
        }

        public static void WriteRedBackground(string s)
        {
            Write($"%bred{s}%reset");
        }

        public static void WriteGreenBackground(string s)
        {
            Write($"%bgreen{s}%reset");
        }

        public static void WriteYellowBackground(string s)
        {
            Write($"%byellow{s}%reset");
        }

        public static void WriteBlueBackground(string s)
        {
            Write($"%bblue{s}%reset");
        }

        public static void WriteMagentaBackground(string s)
        {
            Write($"%bmagenta{s}%reset");
        }

        public static void WriteCyanBackground(string s)
        {
            Write($"%bcyan{s}%reset");
        }

        public static void WriteWhiteBackground(string s)
        {
            Write($"%bwhite{s}%reset");
        }

        public static void WriteBlackBackgroundLine(string s)
        {
            WriteBlackBackground(s + "\n\r");
        }

        public static void WriteRedBackgroundLine(string s)
        {
            WriteRedBackground(s + "\n\r");
        }

        public static void WriteGreenBackgroundLine(string s)
        {
            WriteGreenBackground(s + "\n\r");
        }

        public static void WriteYellowBackgroundLine(string s)
        {
            WriteYellowBackground(s + "\n\r");
        }

        public static void WriteBlueBackgroundLine(string s)
        {
            WriteBlueBackground(s + "\n\r");
        }

        public static void WriteMagentaBackgroundLine(string s)
        {
            WriteMagentaBackground(s + "\n\r");
        }

        public static void WriteCyanBackgroundLine(string s)
        {
            WriteCyanBackground(s + "\n\r");
        }

        public static void WriteWhiteBackgroundLine(string s)
        {
            WriteWhiteBackground(s + "\n\r");
        }
        #endregion

        #region Bold Color
        public static void WriteBoldBlack(string s)
        {
            Write($"%boldblack{s}%reset");
        }

        public static void WriteBoldRed(string s)
        {
            Write($"%boldred{s}%reset");
        }

        public static void WriteBoldGreen(string s)
        {
            Write($"%boldgreen{s}%reset");
        }

        public static void WriteBoldYellow(string s)
        {
            Write($"%boldyellow{s}%reset");
        }

        public static void WriteBoldBlue(string s)
        {
            Write($"%boldblue{s}%reset");
        }

        public static void WriteBoldMagenta(string s)
        {
            Write($"%boldmagenta{s}%reset");
        }

        public static void WriteBoldCyan(string s)
        {
            Write($"%boldcyan{s}%reset");
        }

        public static void WriteBoldWhite(string s)
        {
            Write($"%boldwhite{s}%reset");
        }

        public static void WriteBoldBlackLine(string s)
        {
            WriteBoldBlack(s + "\n\r");
        }

        public static void WriteBoldRedLine(string s)
        {
            WriteBoldRed(s + "\n\r");
        }

        public static void WriteBoldGreenLine(string s)
        {
            WriteBoldGreen(s + "\n\r");
        }

        public static void WriteBoldYellowLine(string s)
        {
            WriteBoldYellow(s + "\n\r");
        }

        public static void WriteBoldBlueLine(string s)
        {
            WriteBoldBlue(s + "\n\r");
        }

        public static void WriteBoldMagentaLine(string s)
        {
            WriteBoldMagenta(s + "\n\r");
        }

        public static void WriteBoldCyanLine(string s)
        {
            WriteBoldCyan(s + "\n\r");
        }

        public static void WriteBoldWhiteLine(string s)
        {
            WriteBoldWhite(s + "\n\r");
        }
        #endregion

        public static void Write(string s)
        {
            System.Console.Write(
                s.Replace(@"\%", @"\%*\")
                .Replace("%reset", "\u001b[0m")
                .Replace("%underline", "\u001b[4m")
                .Replace("%nounderline", "\u001b[24m")
                .Replace("%negative", "\u001b[7m")
                .Replace("%positive", "\u001b[27m")
                .Replace("%black", "\u001b[30m")
                .Replace("%red", "\u001b[31m")
                .Replace("%green", "\u001b[32m")
                .Replace("%yellow", "\u001b[33m")
                .Replace("%blue", "\u001b[34m")
                .Replace("%magenta", "\u001b[35m")
                .Replace("%cyan", "\u001b[36m")
                .Replace("%white", "\u001b[37m")
                .Replace("%freset", "\u001b[39m")
                .Replace("%bblack", "\u001b[40m")
                .Replace("%bred", "\u001b[41m")
                .Replace("%bgreen", "\u001b[42m")
                .Replace("%byellow", "\u001b[43m")
                .Replace("%bblue", "\u001b[44m")
                .Replace("%bmagenta", "\u001b[45m")
                .Replace("%bcyan", "\u001b[46m")
                .Replace("%bwhite", "\u001b[47m")
                .Replace("%end", "\u001b[48m")
                .Replace("%breset", "\u001b[49m")
                .Replace("%boldblack", "\u001b[90m")
                .Replace("%boldred", "\u001b[91m")
                .Replace("%boldgreen", "\u001b[92m")
                .Replace("%boldyellow", "\u001b[93m")
                .Replace("%boldblue", "\u001b[94m")
                .Replace("%boldmagenta", "\u001b[95m")
                .Replace("%boldcyan", "\u001b[96m")
                .Replace("%boldwhite", "\u001b[97m")
                .Replace("%boldbblack", "\u001b[100m")
                .Replace("%boldbred", "\u001b[101m")
                .Replace("%boldbgreen", "\u001b[102m")
                .Replace("%boldbyellow", "\u001b[103m")
                .Replace("%boldbblue", "\u001b[104m")
                .Replace("%boldbmagenta", "\u001b[105m")
                .Replace("%boldbcyan", "\u001b[106m")
                .Replace("%boldbwhite", "\u001b[107m")
                .Replace("%bold", "\u001b[1m")
                .Replace("Default____", "\u001b[0m")
                .Replace("Bold____", "\u001b[1m")
                .Replace("Underline____", "\u001b[4m")
                .Replace("No_underline____", "\u001b[24m")
                .Replace("Negative____", "\u001b[7m")
                .Replace("Positive____", "\u001b[27m")
                .Replace("Foreground_Black____", "\u001b[30m")
                .Replace("Foreground_Red____", "\u001b[31m")
                .Replace("Foreground_Green____", "\u001b[32m")
                .Replace("Foreground_Yellow____", "\u001b[33m")
                .Replace("Foreground_Blue____", "\u001b[34m")
                .Replace("Foreground_Magenta____", "\u001b[35m")
                .Replace("Foreground_Cyan____", "\u001b[36m")
                .Replace("Foreground_White____", "\u001b[37m")
                .Replace("Foreground_Default____", "\u001b[39m")
                .Replace("Background_Black____", "\u001b[40m")
                .Replace("Background_Red____", "\u001b[41m")
                .Replace("Background_Green____", "\u001b[42m")
                .Replace("Background_Yellow____", "\u001b[43m")
                .Replace("Background_Blue____", "\u001b[44m")
                .Replace("Background_Magenta____", "\u001b[45m")
                .Replace("Background_Cyan____", "\u001b[46m")
                .Replace("Background_White____", "\u001b[47m")
                .Replace("Background_Extended____", "\u001b[48m")
                .Replace("Background_Default____", "\u001b[49m")
                .Replace("Bright_Foreground_Black____", "\u001b[90m")
                .Replace("Bright_Foreground_Red____", "\u001b[91m")
                .Replace("Bright_Foreground_Green____", "\u001b[92m")
                .Replace("Bright_Foreground_Yellow____", "\u001b[93m")
                .Replace("Bright_Foreground_Blue____", "\u001b[94m")
                .Replace("Bright_Foreground_Magenta____", "\u001b[95m")
                .Replace("Bright_Foreground_Cyan____", "\u001b[96m")
                .Replace("Bright_Foreground_White____", "\u001b[97m")
                .Replace("Bright_Background_Black____", "\u001b[100m")
                .Replace("Bright_Background_Red____", "\u001b[101m")
                .Replace("Bright_Background_Green____", "\u001b[102m")
                .Replace("Bright_Background_Yellow____", "\u001b[103m")
                .Replace("Bright_Background_Blue____", "\u001b[104m")
                .Replace("Bright_Background_Magenta____", "\u001b[105m")
                .Replace("Bright_Background_Cyan____", "\u001b[106m")
                .Replace("Bright_Background_White____", "\u001b[107m")
                .Replace("Draw_SE____", "\u001b(0j\u001b(B")
                .Replace("Draw_NE____", "\u001b(0k\u001b(B")
                .Replace("Draw_NW____", "\u001b(0l\u001b(B")
                .Replace("Draw_SW____", "\u001b(0m\u001b(B")
                .Replace("Draw_Cross____", "\u001b(0n\u001b(B")
                .Replace("Draw_Horizontal____", "\u001b(0q\u001b(B")
                .Replace("Draw_MiddleLeft____", "\u001b(0t\u001b(B")
                .Replace("Draw_MiddleRight____", "\u001b(0u\u001b(B")
                .Replace("Draw_BottomT____", "\u001b(0v\u001b(B")
                .Replace("Draw_TopT____", "\u001b(0w\u001b(B")
                .Replace("Draw_Vertical____", "\u001b(0x\u001b(B")
                .Replace("%se", "\u001b(0j\u001b(B")
                .Replace("%ne", "\u001b(0k\u001b(B")
                .Replace("%nw", "\u001b(0l\u001b(B")
                .Replace("%sw", "\u001b(0m\u001b(B")
                .Replace("%cross", "\u001b(0n\u001b(B")
                .Replace("%horizontal", "\u001b(0q\u001b(B")
                .Replace("%middleleft", "\u001b(0t\u001b(B")
                .Replace("%middleright", "\u001b(0u\u001b(B")
                .Replace("%bottomt", "\u001b(0v\u001b(B")
                .Replace("%topt", "\u001b(0w\u001b(B")
                .Replace("%vertical", "\u001b(0x\u001b(B")
                .Replace(@"\%*\", "%")
            );
        }
    }
}
