using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("---BasePlayerManager---");
            Console.WriteLine(player.PLayerName + " eklendi.");
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
