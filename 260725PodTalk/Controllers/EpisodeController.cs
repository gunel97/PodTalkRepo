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

        public IActionResult Details(int id)
        {
            var episode = _dbContext.Episodes.Include(s=>s.Speaker).ThenInclude(sp=>sp.SpeakerProfessions).ThenInclude(p=>p.Profession).FirstOrDefault(ep => ep.Id == id);
            var relatedEpisodes = _dbContext.Episodes.Include(s => s.Speaker).ThenInclude(sp => sp.SpeakerProfessions).ThenInclude(p => p.Profession).ToList();
           
            if (episode == null)
            {
                return NotFound();
            }

            var episodeDetailsViewModel = new EpisodeViewModel
            {
                Episode = episode,
                RelatedEpisodes = relatedEpisodes
            };

            return View(episodeDetailsViewModel);
        }

    }
}
