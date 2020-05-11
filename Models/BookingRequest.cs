using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Tutor_Booking_Final.Models
{
    //Booking Request containing the student tutor and the date
    public class BookingRequest
    {
        public int Id { get; set; }


        public int StudentId { get; set; }

        public int TutorId { get; set; }

        public Tutor Tutor { get; set; }

        public Student Student { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }



    }
}
