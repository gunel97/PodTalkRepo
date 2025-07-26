using _260725PodTalk.DataContext.Entities;

namespace _260725PodTalk.Models
{
    public class HomeViewModel
    {
        public List<Speaker> Speakers { get; set; } = [];
        public List<Topic> Topics { get; set; } = [];
        public List<Profession> Professions { get; set; } = [];
        public List<Episode> Episodes { get; set;} = [];
        public List<SpeakerProfession> SpeakerProfessions { get; set; } = [];

    }
}
