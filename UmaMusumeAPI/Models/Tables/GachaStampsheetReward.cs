using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class GachaStampsheetReward
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int RewardType { get; set; }
        public int RewardOrder { get; set; }
        public int ItemId { get; set; }
        public int ItemCategory { get; set; }
        public int ItemNum { get; set; }
    }
}
