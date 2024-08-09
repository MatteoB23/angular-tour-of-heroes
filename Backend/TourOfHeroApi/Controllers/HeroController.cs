using Microsoft.AspNetCore.Mvc;
using TourOfHeroApi.Models;
using TourOfHeroApi.Services;

namespace TourOfHeroApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {
        private readonly HeroService _heroService;

        public HeroController(HeroService heroService)
        {
            _heroService = heroService;
        }
        

        [HttpGet]
        public List<Hero> GetHeroes()
        {
            return _heroService.GetHeroList();
        }

        [HttpGet("{Id}")]
        public Hero GetHero(Guid Id)
        {
            return _heroService.GetById(Id);
        }

        [HttpPost]
        public Hero CreateHeroes(Hero hero)
        {
            return _heroService.CreateHero(hero);
        }


        [HttpDelete("{Id}")]
        public void DeleteHero(Guid Id)
        {
            _heroService.DeleteHero(Id);
        }

        [HttpPut]
        public Hero UpdateHero(Hero hero)
        {
            return _heroService.UpdateHero(hero);
        }

    }
}
