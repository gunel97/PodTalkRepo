using _260725PodTalk.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace _260725PodTalk.ViewComponents
{
    public class EpisodeViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public EpisodeViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var episodes = _dbContext.Episodes.Take(3).ToList();

            return View(episodes);
        }
    }
}
