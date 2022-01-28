using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicSite.Models;
using Microsoft.AspNetCore.Identity;
using MusicSite.Models.Albums;
using MusicSite.Models.Albums.AlbumsRepository;
using MusicSite.Models.Reviews;
using MusicSite.Models.Reviews.ReviewsRepository;
using MusicSite.Models.Tracks;
using MusicSite.Models.Track;

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


            services.AddTransient<IAlbum, AlbumRepository>();
            services.AddTransient<IReview, ReviewRepository>();
            services.AddTransient<ICRUDTrackRepository, CRUDTrackRepository>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<AppDataBase>()
                .AddDefaultTokenProviders();
            services.AddAuthorization(o=>o.AddPolicy("Admin", p=>p.RequireRole("Admin")));
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
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
