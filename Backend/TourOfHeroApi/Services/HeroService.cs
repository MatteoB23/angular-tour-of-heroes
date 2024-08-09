using System.Security.Cryptography;
using TourOfHeroApi.Database;
using TourOfHeroApi.Models;

namespace TourOfHeroApi.Services
{
    public class HeroService
    {
        private readonly HeroDbContext _context;

        public HeroService(HeroDbContext context)
        {
            _context = context;
        }

        public List<Hero> GetHeroList()
        {
            return _context.Heroes.ToList();
        }

        public Hero CreateHero(Hero hero)
        {
            _context.Heroes.Add(hero);
            _context.SaveChanges();
            return hero;
        }

        public void DeleteHero(Guid Id)
        {
            var heroToRemove = _context.Heroes.SingleOrDefault(hero => hero.Id == Id);
            _context.Heroes.Remove(heroToRemove);
            _context.SaveChanges();
        }

        public Hero UpdateHero(Hero hero)
        {
            var temp = _context.Heroes.SingleOrDefault(heroToUpdate => heroToUpdate.Id == hero.Id);

            if (temp != null)
            {
                temp.Name = hero.Name;
                temp.Id = hero.Id;
                temp.Alter = hero.Alter;
            }

            _context.SaveChanges();
            return temp;
        }

        public Hero GetById(Guid Id)
        {
            var hero = _context.Heroes.SingleOrDefault(hero => hero.Id == Id);
            return hero;
        }
    }
}
