using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class OmakaseFilter
    {
        public int FilterId { get; set; }
        public int IsModifiable { get; set; }
        public int CommandId { get; set; }
        public int ScenarioId { get; set; }
        public int ConditionSetId { get; set; }
        public int Priority { get; set; }
    }
}
