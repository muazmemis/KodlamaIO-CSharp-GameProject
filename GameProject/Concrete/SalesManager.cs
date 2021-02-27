using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        public void Sales(Player player, Game game)
        {
            Console.WriteLine("---SalesManager---");
            Console.WriteLine("{0} {1} oyununu satın aldı.", player.PLayerName, game.GameName);
        }

        public void SalesCampaign(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine("{0} {1} oyununu {2} kampanyası ile satın aldı.\n", player.PLayerName,game.GameName,campaign.CampaignName);
        }
    }
}
