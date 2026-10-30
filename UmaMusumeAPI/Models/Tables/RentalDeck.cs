using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RentalDeck
    {
        public int Id { get; set; }
        public int DistanceType { get; set; }
        public int GroundType { get; set; }
        public int DispOrder { get; set; }
        public int DeckNameId { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
