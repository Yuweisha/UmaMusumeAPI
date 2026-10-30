using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeStoryConditionSet
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int StoryId { get; set; }
        public int ConditionType { get; set; }
        public int ConditionStoryId1 { get; set; }
        public int GainSelect1 { get; set; }
        public int SelectIndex1 { get; set; }
        public int ConditionStoryId2 { get; set; }
        public int GainSelect2 { get; set; }
        public int SelectIndex2 { get; set; }
        public int ConditionStoryId3 { get; set; }
        public int GainSelect3 { get; set; }
        public int SelectIndex3 { get; set; }
    }
}
