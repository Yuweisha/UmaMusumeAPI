using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class OmakaseStopperEvent
    {
        public int StopperId { get; set; }
        public int IsModifiable { get; set; }
        public int ConditionType { get; set; }
        public int StopType { get; set; }
        public int ScenarioId { get; set; }
        public int StoryId { get; set; }
    }
}
