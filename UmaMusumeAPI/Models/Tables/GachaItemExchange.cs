using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class GachaItemExchange
    {
        public int Id { get; set; }
        public int GachaId { get; set; }
        public int ItemId { get; set; }
        public int ItemCategory { get; set; }
        public int ItemNum { get; set; }
        public int PayItemNum { get; set; }
        public int DispOrder { get; set; }
    }
}
