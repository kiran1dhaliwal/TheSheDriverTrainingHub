using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheFinalSheDriverTrainingHub.Areas.Identity.Data;
using TheFinalSheDriverTrainingHub.Models;

[assembly: HostingStartup(typeof(TheFinalSheDriverTrainingHub.Areas.Identity.IdentityHostingStartup))]
namespace TheFinalSheDriverTrainingHub.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TheFinalSheDriverTrainingHubContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                //services.AddDefaultIdentity<TheFinalSheDriverTrainingHubUser>()
                //    .AddEntityFrameworkStores<TheFinalSheDriverTrainingHubContext>();

                services.AddIdentity<TheFinalSheDriverTrainingHubUser, IdentityRole>()
                .AddDefaultUI()
                .AddRoles<IdentityRole>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<TheFinalSheDriverTrainingHubContext>();

            });
        }
    }
}