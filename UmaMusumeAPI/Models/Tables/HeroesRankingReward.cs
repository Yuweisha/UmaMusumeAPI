using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HeroesRankingReward
    {
        public int Id { get; set; }
        public int HeroesId { get; set; }
        public int HeroesRankingBorderId { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }
}
