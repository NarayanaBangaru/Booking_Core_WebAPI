using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HotelBooking.Models
{
    public class CapacityProvider
    {
        /// <summary>
        /// The ID of the Capacity Provider.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The Name of the Capacity Provider.
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Name { get; set; }

        /// <summary>
        /// The City of the Capacity Provider.
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string City { get; set; }

        /// <summary>
        /// The Phone of the Capacity Provider.
        /// </summary>
        [Phone]
        [Column(TypeName = "nvarchar(max)")]
        public string Phone { get; set; }

        /// <summary>
        /// The Email ID of the Capacity Provider.
        /// </summary>
        [EmailAddress]
        [Column(TypeName = "nvarchar(max)")]
        public string Email { get; set; }

        /// <summary>
        /// The Contract number of the Capacity Provider.
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Contract_Number { get; set; }
       
        [IgnoreDataMember]
        public ICollection<Booking> Bookings { get; set; }
    }
}
