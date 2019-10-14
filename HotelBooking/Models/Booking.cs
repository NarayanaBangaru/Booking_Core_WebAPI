using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HotelBooking.Models
{
    public class Booking
    {
        /// <summary>
        /// The ID of the Booking.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The Name of the Booking.
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Object_Name { get; set; }

        /// <summary>
        /// Foreign Key relation.
        /// </summary>
        [Required]
        public int Capacity_Provider_Id { get; set; }
        [Required]
        [IgnoreDataMember]
        [ForeignKey("Capacity_Provider_Id")]
        public CapacityProvider CapacityProvider { get; set; }

        /// <summary>
        /// The Date of the Booking.
        /// </summary>
        [Required]
        [Column(TypeName = "date")]
        public DateTime Date_From { get; set; }

        /// <summary>
        /// The Date of the Booking.
        /// </summary>
        [Required]
        [Column(TypeName = "date")]
        public DateTime Date_To { get; set; }

        /// <summary>
        /// To check booking status.
        /// </summary>
        [Required]
        [Column(TypeName = "bit")]
        public bool Is_Active { get; set; }

        /// <summary>
        /// The Money of the Booking.
        /// </summary>
        [Required]
        [Column(TypeName = "money")]
        public float Amount { get; set; }

        /// <summary>
        /// The Currency of the Booking.
        /// </summary>
        [Required]
        [Column(TypeName ="nvarchar(max)")]
        public string Currency { get; set; }

        /// <summary>
        /// Any comment of the Booking.
        /// </summary>
        [Column(TypeName ="Text")]
        public string Comment { get; set; }

    }
}
