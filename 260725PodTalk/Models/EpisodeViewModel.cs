using _260725PodTalk.DataContext.Entities;

namespace _260725PodTalk.Models
{
    public class EpisodeViewModel
    {
        public List<Episode> RelatedEpisodes { get; set; } = [];
        public Episode? Episode { get; set; }
    }
}
