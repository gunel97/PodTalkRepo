using _260725PodTalk.DataContext.Entities;

namespace _260725PodTalk.Models
{
    public class EpisodeDetailsViewModel
    {
        public Episode? Episode { get; set; }
        public List<Episode> RelatedEpisodes { get; set; } = [];
    }
}
