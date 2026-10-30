using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class IdleSingleModeTrainingCut
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int CommandId { get; set; }
        public int MaxTrainingLv { get; set; }
        public int DesignatedCharaId { get; set; }
    }
}
