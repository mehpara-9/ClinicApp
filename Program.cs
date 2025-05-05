using ClinicApp3.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            string connectionStr = "Server=ACER\\SQLEXPRESS;Database=ClinicAppDb;Trusted_Connection=True;TrustServerCertificate=True";
            builder.Services.AddDbContext<AppDbContext>(mehpare=>mehpare.UseSqlServer(connectionStr));
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute(
               name:"Default",
             pattern:"{Controller=Home}/{Action=Index}/{id?}" 
             );
            

            app.Run();
        }
    }
}
