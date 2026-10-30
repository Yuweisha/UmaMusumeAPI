using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SubscriptionTotalReward
    {
        public long Id { get; set; }
        public long TotalMonth { get; set; }
        public long RewardItemId { get; set; }
        public long RewardItemCategory { get; set; }
        public long RewardItemNum { get; set; }
    }
}
