namespace _260725PodTalk.DataContext.Entities
{
    public class Speaker : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<SpeakerProfession> SpeakerProfessions { get; set; } = [];
        public List<Episode> Episodes { get; set; } = [];
    }
}
