using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class GachaStampsheet
    {
        public int Id { get; set; }
        public int GachaId { get; set; }
        public int SheetNum { get; set; }
        public int IsLoop { get; set; }
        public int StampsheetRewardGroupId { get; set; }
        public int StampsheetOddsGroupId { get; set; }
    }
}
