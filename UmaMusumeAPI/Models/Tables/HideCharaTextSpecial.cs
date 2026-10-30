using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HideCharaTextSpecial
    {
        public int Id { get; set; }
        public int SpecialVoiceExceptId { get; set; }
        public int CharacterId { get; set; }
        public int VoiceId { get; set; }
    }
}
