namespace _260725PodTalk.DataContext.Entities
{
    public class SpeakerProfession : BaseEntity
    {
        public int SpeakerId { get; set; }
        public Speaker? Speaker { get; set; }
        public int ProfessionId { get; set; }
        public Profession? Profession { get; set; }
    }
}
