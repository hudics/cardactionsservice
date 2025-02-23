
using CardActionsService.Data;
using CardActionsService.Domain.Interfaces;
using CardActionsService.Domain.Interfaces.Services;
using CardActionsService.Domain.Services;
using CardActionsService.Infrastructure.Data;
using CardActionsService.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CardActionsService.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("CardActionsDatabase")));

            // Add services to the container.
            builder.Services.AddScoped<IActionRepository, ActionRepository>();
            builder.Services.AddScoped<ICardService, CardService>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.Migrate(); // Ensure the database exists when launching the project for the interview
                DbInitializer.Seed(context); // Some initial data
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
