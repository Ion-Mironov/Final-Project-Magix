using Final___Magix.Api;
using Final___Magix.DataContext;

namespace Final___Magix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<CardContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

			// Register ScryfallApiClient with dependency injection.
			builder.Services.AddHttpClient<ScryfallApiClient>(client =>
			{
				client.BaseAddress = new Uri("https://api.scryfall.com/");
			});

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}