using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HideCharaTextScenario
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int Period { get; set; }
        public int CharacterId { get; set; }
        public int DressId { get; set; }
        public int VoiceId { get; set; }
    }
}
