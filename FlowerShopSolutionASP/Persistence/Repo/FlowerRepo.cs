using FlowerShopSolutionASP.Models;

namespace FlowerShopSolutionASP.Persistence.Repo
{
    public class FlowerRepo
    {
        private List<Flower> _flowers;

        public void GetFlowers()
        {
            _flowers = new List<Flower>
            {
                new Flower{Id = 1, Name = "Test", Description = "tteststest", Season = "Lel?"},
                new Flower{Id = 2, Name = "Test", Description = "tteststest", Season = "Lel?"},
                new Flower{Id = 3, Name = "Test", Description = "tteststest", Season = "Lel?"},
                new Flower{Id = 4, Name = "Test", Description = "tteststest", Season = "Lel?"},
                new Flower{Id = 5, Name = "Test", Description = "tteststest", Season = "Lel?"}
            };
        }
    }
}
