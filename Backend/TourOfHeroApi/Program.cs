using Microsoft.EntityFrameworkCore;
using TourOfHeroApi.Database;
using TourOfHeroApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<HeroDbContext>(optionsAction => 
    optionsAction.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );

builder.Services.AddCors(c => {
    c.AddPolicy("AllowAll", options =>
        {
            options.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        }
    );
});

builder.Services.AddTransient<HeroService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseStaticFiles();

app.UseRouting();

app.UseCors("AllowAll");

app.Migrate<HeroDbContext>();

app.UseAuthorization();

app.MapControllers();

app.Run();

