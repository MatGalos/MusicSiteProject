using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicSite.Models;
using static MusicSite.Models.User;
using static MusicSite.Models.Album;
using static MusicSite.Models.Review;
using static MusicSite.Models.Track;
using MusicSite.Models.Login;
using Microsoft.AspNetCore.Identity;

namespace MusicSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDataBase>(options => options.UseSqlServer(Configuration["Data:MusicSite:ConnectionStarting"]));

            services.AddTransient<IDB, Ef>();

            services.AddTransient<ICRUDUserRepository, CRUDUserRepository>();
            services.AddTransient<ICRUDAlbumRepository, CRUDAlbumRepository>();
            services.AddTransient<ICRUDReviewRepository, CRUDReviewRepository>();
            services.AddTransient<ICRUDTrackRepository, CRUDTrackRepository>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<AppDataBase>()
                .AddDefaultTokenProviders();
            services.AddSession();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            

            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
