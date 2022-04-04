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
        public static void Draw()
        {

        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int columns = 0; columns <= 30; columns++)
                Console.Write("-");
            Console.Write("+");
        }
    }
}
