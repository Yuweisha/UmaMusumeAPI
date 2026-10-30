using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainingChallengeRankingBorder
    {
        public long Id { get; set; }
        public long TrainingChallengeMasterId { get; set; }
        public long RankStart { get; set; }
        public long RankEnd { get; set; }
    }
}
