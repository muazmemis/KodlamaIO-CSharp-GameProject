using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sales(Player player, Game game);
        void SalesCampaign(Player player, Game game, Campaign campaign);
    }
}
