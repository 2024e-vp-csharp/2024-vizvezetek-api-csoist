using Microsoft.EntityFrameworkCore;
using Vizvezetek.API.Models;

namespace Vizvezetek.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<vizvezetekContext>(options =>
            {
                options.UseMySql(builder.Configuration.GetConnectionString("Default"), ServerVersion.Parse("10.4.24-mariadb"));
                
                options.EnableSensitiveDataLogging();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}