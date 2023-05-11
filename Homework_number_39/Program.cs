using System;

namespace Homework_number_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positionX = 10;
            int positionY = 10;

            Renderer renderer = new Renderer();
            Player player = new Player(positionX, positionY);

            renderer.DrawPlayer(player.PositionX, player.PositionY);
        }
    }

    class Player
    {
        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
    }

    class Renderer
    {
        public void DrawPlayer(int positionX, int positionY, char playerSymbol = '@')
        {
            Console.SetCursorPosition(positionY, positionX);
            Console.Write(playerSymbol);
        }
    }
}
