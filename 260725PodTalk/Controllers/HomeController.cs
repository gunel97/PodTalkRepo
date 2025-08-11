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
            var speakers = _dbContext.Speakers.ToList();
            var episodes = _dbContext.Episodes.Include(x=>x.Speaker).Include(x=>x.Topic).OrderByDescending(x=>x.Id).Take(2).ToList();

            var homeViewModel = new HomeViewModel
            {
                Topics = topics,
                Speakers = speakers,
                Episodes = episodes,
                TrendingEpisodes = _dbContext.Episodes.Take(2).ToList()
            };

            return View(homeViewModel);
        }

    }
}
