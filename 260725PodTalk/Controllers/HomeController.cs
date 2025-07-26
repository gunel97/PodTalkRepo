using System.Diagnostics;
using _260725PodTalk.DataContext;
using _260725PodTalk.DataContext.Entities;
using _260725PodTalk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _260725PodTalk.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var topics = _dbContext.Topics.ToList();
            var speakers = _dbContext.Speakers.Include(sp => sp.SpeakerProfessions).ThenInclude(p => p.Profession).ToList();
            var episodes = _dbContext.Episodes.ToList();

            var homeViewModel = new HomeViewModel
            {
                Topics = topics,
                Speakers = speakers,
                Episodes = episodes
            };

            return View(homeViewModel);
        }

    }
}
