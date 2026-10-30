using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RentalDeckCard
    {
        public int Id { get; set; }
        public int RentalDeckId { get; set; }
        public int SupportCardId { get; set; }
        public int LimitBreakCount { get; set; }
        public int Position { get; set; }
    }
}
