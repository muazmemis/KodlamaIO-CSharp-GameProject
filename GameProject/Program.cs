using System;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player()
            {PLayerName = "Ahmet", PlayerSurname = "Veli", PlayerId = 1, NationalId = 5261, DateofBirth = 2000};
           
            // Mernis ile girişi doğrular.
            BasePlayerManager basePlayerManager = new NeroPlayerManager(new MernisServiceAdapter());
            basePlayerManager.Add(player);
            basePlayerManager.Update(player);
            basePlayerManager.Delete(player);
            

            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player);
            playerManager.Update(player);
            playerManager.Delete(player);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign(){CampaignId = 1,CampaignName = "Bahar indirimi",Discount = 0.25M};
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            GameManager gameManager = new GameManager();
            Game game = new Game(){GameId = 1,GameName = "FIFA 2021",GamePrice = 450};
            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(player, game);
            salesManager.SalesCampaign(player, game, campaign);
        }
    }
}
