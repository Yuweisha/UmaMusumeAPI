using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleMode10Buff
    {
        public int Id { get; set; }
        public int BuffId { get; set; }
        public int LegendId { get; set; }
        public int BuffRank { get; set; }
        public int BuffTrigger { get; set; }
        public int ConditionGroupId { get; set; }
        public int EffectGroupId { get; set; }
        public int BuffTurnType { get; set; }
        public int BuffTurnValue { get; set; }
        public int BuffCt { get; set; }
        public int Icon { get; set; }
        public int IsEnableInactivation { get; set; }
    }
}
