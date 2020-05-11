using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Online_Tutor_Booking_Final.Models;

[assembly: HostingStartup(typeof(Online_Tutor_Booking_Final.Areas.Identity.IdentityHostingStartup))]
namespace Online_Tutor_Booking_Final.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Online_Tutor_Booking_IdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Online_Tutor_Booking_IdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                     .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<Online_Tutor_Booking_IdentityContext>();
            });
        }
    }
}