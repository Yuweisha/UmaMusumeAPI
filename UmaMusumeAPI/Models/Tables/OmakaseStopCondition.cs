using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class OmakaseStopCondition
    {
        public int StopConditionId { get; set; }
        public int ConditionType { get; set; }
        public int StopperType { get; set; }
        public int ScenarioId { get; set; }
    }
}
