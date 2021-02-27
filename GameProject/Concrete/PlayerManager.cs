using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            Console.WriteLine("---PlayerManager---");
            Console.WriteLine(player.PLayerName+ " eklendi.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.PLayerName + " silindi.\n");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.PLayerName + " güncellendi.");
        }
    }
}
