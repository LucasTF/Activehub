using Domain.Entities;

namespace Persistence.Seeds
{
    public class ActivitySeed
    {
        public static async Task SeedData(ApplicationDbContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Antiga Atividade 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Atividade 2 meses atrás",
                    Category = "bebidas",
                    City = "São Paulo",
                    Venue = "Bar A",
                },
                new Activity
                {
                    Title = "Antiga Atividade 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Atividade 1 mês atrás",
                    Category = "cultura",
                    City = "São Paulo",
                    Venue = "Museu A",
                },
                new Activity
                {
                    Title = "Futura Atividade 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Atividade em 1 mês",
                    Category = "cultura",
                    City = "Rio de Janeiro",
                    Venue = "Museu B",
                },
                new Activity
                {
                    Title = "Futura Atividade 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Atividade 2 meses no futuro",
                    Category = "musica",
                    City = "Rio de Janeiro",
                    Venue = "Rock in Rio",
                },
                new Activity
                {
                    Title = "Futura Atividade 2",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Atividade 3 meses no futuro",
                    Category = "bebidas",
                    City = "Belo Horizonte",
                    Venue = "Bar B",
                },
                new Activity
                {
                    Title = "Futura Atividade 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Atividade 4 meses no futuro",
                    Category = "bebidas",
                    City = "São Paulo",
                    Venue = "Bar C",
                },
                new Activity
                {
                    Title = "Futura Atividade 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Atividade 5 meses no futuro",
                    Category = "bebidas",
                    City = "São Paulo",
                    Venue = "Bar D",
                },
                new Activity
                {
                    Title = "Futura Atividade 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Atividade 6 meses no futuro",
                    Category = "musica",
                    City = "São Paulo",
                    Venue = "Lollapalooza",
                },
                new Activity
                {
                    Title = "Futura Atividade 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Atividade 2 meses atrás",
                    Category = "viagem",
                    City = "São Paulo",
                    Venue = "Interlagos",
                },
                new Activity
                {
                    Title = "Futura Atividade 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Atividade 8 meses no futuro",
                    Category = "filme",
                    City = "São Paulo",
                    Venue = "Cinema",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}