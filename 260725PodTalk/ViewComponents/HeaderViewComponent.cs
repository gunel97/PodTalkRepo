using _260725PodTalk.DataContext;
using _260725PodTalk.Models;
using Microsoft.AspNetCore.Mvc;

namespace _260725PodTalk.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var headerViewModel = new HeaderViewModel
            {
                LogoUrl = "pod-talk-logo.png"
            };

            return View(headerViewModel);
        }
    }
}
