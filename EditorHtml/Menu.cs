using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
        }
        public static void Draw(string symbol, string symbolValue, int value)
        {
            Console.Write(symbol);
            for (int columns = 0; columns <= value; columns++)
                Console.Write(symbolValue);
            Console.Write(symbol);
            Console.Write("\n");

        }
        public static void DrawLines()
        {
            for (int lines = 0; lines <= 10; lines++)
                Draw("|", " ", 30);

        }

        public static void DrawScreen()
        {
            Draw("+", "-", 30);
            DrawLines();
            Draw("+", "-", 30);
        }
    }
}
