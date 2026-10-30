using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeRaceUniqueCondition
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int Year { get; set; }
        public int RaceProgramId { get; set; }
        public int RaceConditionId { get; set; }
        public int FrameOrder { get; set; }
        public int FinishOrder0 { get; set; }
    }
}
