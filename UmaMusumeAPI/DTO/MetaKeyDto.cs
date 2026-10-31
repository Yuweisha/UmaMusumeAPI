namespace UmaMusumeAPI.DTO
{
    /// <summary>Minimal shape needed to look a decryption key up by resource hash.</summary>
    public class MetaKeyDto
    {
        public string H { get; set; }
        public string N { get; set; }
        public long? E { get; set; }
    }
}
