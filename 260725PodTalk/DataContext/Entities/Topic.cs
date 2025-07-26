namespace _260725PodTalk.DataContext.Entities
{
    public class Topic : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public List<Episode> Episodes { get; set; } = [];

    }
}
