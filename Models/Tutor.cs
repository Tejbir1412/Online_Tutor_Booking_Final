using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Tutor_Booking_Final.Models
{
    //Tutor details including contact number and email
    public class Tutor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }
    }
}
