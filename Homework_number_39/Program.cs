using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positionX = 10;
            int positionY = 10;

            Render render = new Render();
            Player player = new Player(positionX, positionY);

            render.DrawPlayer(player.PositionX, player.PositionY);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }

    class Render
    {
        public void DrawPlayer(int positionX, int positionY, char playerSymbol = '@')
        {
            Console.SetCursorPosition(positionY, positionX);
            Console.Write(playerSymbol);
        }
    }
}
