using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Online_Tutor_Booking_Final.Models;

namespace Online_Tutor_Booking_Final.Models
{
    public class Online_Tutor_Booking_DataContext : DbContext
    {
        public Online_Tutor_Booking_DataContext (DbContextOptions<Online_Tutor_Booking_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Online_Tutor_Booking_Final.Models.BookingRequest> BookingRequest { get; set; }

        public DbSet<Online_Tutor_Booking_Final.Models.Student> Student { get; set; }

        public DbSet<Online_Tutor_Booking_Final.Models.Tutor> Tutor { get; set; }
    }
}
