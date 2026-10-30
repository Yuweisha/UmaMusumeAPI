using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainerSkill
    {
        public long Id { get; set; }
        public long EffectGroupId { get; set; }
        public long NeedItemNum { get; set; }
        public long ActiveTime { get; set; }
        public long EnableSingleMode { get; set; }
        public long EnableIdleSingleMode { get; set; }
        public long EnableGenerateSuccession { get; set; }
        public long Sort { get; set; }
        public long StartDate { get; set; }
    }
}
