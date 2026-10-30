using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleMode11Planning
    {
        public int Id { get; set; }
        public int DeckId { get; set; }
        public int CheckPointType { get; set; }
        public int PlanningTurn { get; set; }
        public int CheckPointTurn { get; set; }
        public int TargetPt { get; set; }
    }
}
