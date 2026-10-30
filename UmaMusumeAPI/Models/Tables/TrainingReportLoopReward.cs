using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainingReportLoopReward
    {
        public long Id { get; set; }
        public long RewardSet { get; set; }
        public long IsPickup { get; set; }
        public long RewardItemId { get; set; }
        public long RewardItemCategory { get; set; }
        public long RewardItemNum { get; set; }
        public long PerPoint { get; set; }
        public long LoopNum { get; set; }
    }
}
