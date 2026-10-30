using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MainStoryCustomLoad
    {
        public int MainStoryDataId { get; set; }
        public int StoryTypeOrder { get; set; }
        public int CustomLoadType { get; set; }
        public string KeepCueName { get; set; }
        public int CustomLoadEffectPattern { get; set; }
        public string ImageEffectAssetName { get; set; }
        public int UseActionCue { get; set; }
        public int WaitTime { get; set; }
        public int TargetStoryId { get; set; }
    }
}
