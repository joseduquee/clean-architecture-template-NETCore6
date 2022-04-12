using CleanArchitecture.Domain;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class StreamerDbContextSeed
    {
        public static async Task SeedAsync(StreamerDbContext context, ILogger<StreamerDbContextSeed> logger)
        {
            if(!context.Streamers.Any())
            {
                context.Streamers.AddRange(GetPreconfigureStreamer());
                await context.SaveChangesAsync();
                logger.LogInformation("Estamos insertando nuevos records al db {context}", typeof(StreamerDbContext).Name);
            }
        }

        private static List<Streamer> GetPreconfigureStreamer()
        {
            return new List<Streamer>
            {
                new Streamer
                {
                    CreatedBy = "Alexander",
                    Name ="Disnep +",
                    Url = "https://www.disneyplus.com/home"
                },new Streamer
                {
                    CreatedBy = "Antonio",
                    Name ="Netfliz",
                    Url = "https://www.netflix.com"
                },
            };
        }

    }
}
