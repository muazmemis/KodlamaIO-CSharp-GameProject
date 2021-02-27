using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class NeroPlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;
        public NeroPlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Add(Player player)
        {
            if(_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.PLayerName + " ait kimlik bilgileri doğrulandı.");
                base.Add(player);
            }

            else
            {
                Console.WriteLine(player.PLayerName+" ait kimlik bilgileri doğrulanamadı.");
            }
        }
    }
}
