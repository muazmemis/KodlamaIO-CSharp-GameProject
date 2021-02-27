using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("---GameManager---");
            Console.WriteLine(game.GameName + " eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " silindi.\n");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " güncellendi.");
        }
    }
}
