using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class FactorResearchTaskData
    {
        public int Id { get; set; }
        public int FactorResearchEventId { get; set; }
        public int AllFactorItemId { get; set; }
        public int WhiteFactorItemId { get; set; }
        public int PresenMotionChangePoint1 { get; set; }
        public int PresenMotionChangePoint2 { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
    }
}
