namespace _260725PodTalk.DataContext.Entities
{
    public class Episode : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public int Duration { get; set; }
        public string CoverImageUrl { get; set; } = null!;
        public string RecordMp3Path { get; set; } = null!;
        public int DownloadCount { get; set; }
        public int CommentCount { get; set; }
        public int ListeningCount { get; set; }
        public int LikeCount { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; } = null!;
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; } = null!;
    }
}
