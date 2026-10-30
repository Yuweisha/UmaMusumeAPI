using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainingChallengeRankingReward
    {
        public long Id { get; set; }
        public long TrainingChallengeRankingBorderId { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}
