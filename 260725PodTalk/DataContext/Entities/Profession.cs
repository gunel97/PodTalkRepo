namespace _260725PodTalk.DataContext.Entities
{
    public class Profession : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public List<SpeakerProfession> SpeakersProfessions { get; set; } = [];
    }
}
