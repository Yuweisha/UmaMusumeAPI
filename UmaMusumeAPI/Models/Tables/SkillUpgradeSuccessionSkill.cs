using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SkillUpgradeSuccessionSkill
    {
        public long Id { get; set; }
        public long CardId { get; set; }
        public long BaseSkillId { get; set; }
        public long SkillId { get; set; }
        public long StartDate { get; set; }
    }
}
