using _260725PodTalk.DataContext.Entities;

namespace _260725PodTalk.Models
{
    public class EpisodeViewModel
    {
        public List<Episode> TrendingEpisodes { get; set; } = [];
        public List<Episode> Episodes { get; set; } = [];
    }
}
