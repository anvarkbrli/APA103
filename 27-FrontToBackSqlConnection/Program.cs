using _27_FrontToBackSqlConnection.Data;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDBContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("default"));
            });


            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
             name: "default",
             pattern: "{area:exists}/{controller=dashboard}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
