using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HomeWalkPathRestriction
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public string Route { get; set; }
    }
}
