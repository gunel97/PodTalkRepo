using _260725PodTalk.DataContext.Entities;

namespace _260725PodTalk.Models
{
    public class FooterViewModel
    {
        public List<Social> Socials { get; set; } = [];
        public Bio? Bio { get; set; }
    }
}
