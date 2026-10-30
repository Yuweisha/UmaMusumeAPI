using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeAudienceOverwrite
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int RaceGrade { get; set; }
        public int AudienceType { get; set; }
        public int CrowdSoundType { get; set; }
        public int LiveType { get; set; }
        public int StartTurn { get; set; }
        public int EndTurn { get; set; }
        public int GroupId { get; set; }
    }
}
