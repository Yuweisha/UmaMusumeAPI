using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CardTalentLevelUpgradeMoney
    {
        public int Id { get; set; }
        public int TalentLevel { get; set; }
        public int UpgradeTalentLevel { get; set; }
        public int MoneyNum { get; set; }
    }
}
