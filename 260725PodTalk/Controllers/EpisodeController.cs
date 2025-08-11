using _260725PodTalk.DataContext;
using _260725PodTalk.DataContext.Entities;
using _260725PodTalk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _260725PodTalk.Controllers
{
    public class EpisodeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public EpisodeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  IActionResult Index()
        {
            var episodes = _dbContext.Episodes
               .Include(x => x.Speaker)
               .ThenInclude(x => x!.SpeakerProfessions)
               .ThenInclude(x => x.Profession)
               .Take(2)
               .ToList();
            var trendingEpisodes = _dbContext.Episodes.Take(2).ToList();
            var model = new EpisodeViewModel
            {
                Episodes = episodes,
                TrendingEpisodes = trendingEpisodes
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
                return NotFound();

            var episode = _dbContext.Episodes.Include(s=>s.Speaker).ThenInclude(sp=>sp.SpeakerProfessions).ThenInclude(p=>p.Profession).FirstOrDefault(ep => ep.Id == id);
            var relatedEpisodes = _dbContext.Episodes.Include(s => s.Speaker).ThenInclude(sp => sp.SpeakerProfessions).ThenInclude(p => p.Profession).Take(1).ToList();
           
            if (episode == null)
            {
                return NotFound();
            }

            var episodeDetailsViewModel = new EpisodeDetailsViewModel
            {
                Episode = episode,
                RelatedEpisodes = relatedEpisodes
            };

            return View(episodeDetailsViewModel);
        }

        public IActionResult Partial (int skip)
        {
            var episodes = _dbContext.Episodes
              .Include(x => x.Speaker)
              .ThenInclude(x => x!.SpeakerProfessions)
              .ThenInclude(x => x.Profession)
              .Skip(skip)
              .Take(2)
              .ToList();

            return Json(episodes);
        }

    }
}
