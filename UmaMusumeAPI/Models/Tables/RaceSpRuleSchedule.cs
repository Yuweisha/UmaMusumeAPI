using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceSpRuleSchedule
    {
        public int Id { get; set; }
        public int RaceSpRuleDataId { get; set; }
        public int EventCategory { get; set; }
        public int EventId { get; set; }
        public int EventMonth { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
