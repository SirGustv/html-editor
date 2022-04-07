using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOpitions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }
        public static void Draw(string symbol, string symbolValue, int value)
        {
            //Define quantas colunas a tela irá ter
            Console.Write(symbol);
            for (int columns = 0; columns <= value; columns++)
                Console.Write(symbolValue);
            Console.Write(symbol);
            Console.Write("\n");

        }
        public static void DrawLines()
        {
            //Define as linhas e seus respectivos espaçamentos dentro da tela
            for (int lines = 0; lines <= 10; lines++)
                Draw("|", " ", 30);

        }
        public static void DrawScreen()
        {
            Draw("+", "-", 30);
            DrawLines();
            Draw("+", "-", 30);
        }
        public static void EncapsOptions(int columns, int lines, string text)
        {
            Console.SetCursorPosition(columns, lines);
            Console.Write(text);
        }
        public static void WriteOpitions()
        {
            EncapsOptions(11, 1, "Editor HTML");
            EncapsOptions(10, 2, "=============");
            EncapsOptions(3, 4, "Selecione uma opção abaixo");
            EncapsOptions(3, 6, "1 - Novo Arquivo");
            EncapsOptions(3, 7, "0 - Sair");
            EncapsOptions(3, 9, "Opção desejada: ");
        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }


    }
}
