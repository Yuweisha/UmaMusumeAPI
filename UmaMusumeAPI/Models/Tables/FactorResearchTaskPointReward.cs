using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class FactorResearchTaskPointReward
    {
        public int Id { get; set; }
        public int FactorResearchEventId { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
        public int PickupFlag { get; set; }
        public int RewardPoint { get; set; }
    }
}
