using System.Linq;

namespace MVC.Models
{
    public class Seeder
    {
        public static void SeedData(AppDbContext context)
        {
            if (!context.Categories.Any())
            {
                for (int i = 0; i < SeedItems.Category.Count; i++)
                {
                    context.AddAsync(SeedItems.Category[i]);
                }
                context.SaveChanges();
            }
            if (!context.Pies.Any())
            {
                for(int i = 0; i < SeedItems.Pie.Count; i++)
                {
                    context.AddAsync(SeedItems.Pie[i]);
                }
                context.SaveChanges();
            }
            
        }
    }
}

