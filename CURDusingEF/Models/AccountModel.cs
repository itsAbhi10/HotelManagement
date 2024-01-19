using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CURDusingEF.Models
{
  
    [Table("Booking.Room")]
    public class AccountModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }

        public string RoomNumber { get; set; }

        public string RoomImage { get; set; }

        public decimal RoomPrice { get; set; }

        public string RoomType { get; set; }

        public int RoomCapacity { get; set; }

        public string RoomDescription { get; set; }

        public string IsActive { get; set; }




    }

    [Table("contact")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        

        public int id { get; set; }
        public string fullName { get; set; }

        public string Email { get; set; }

        public Int64 Phoneno { get; set; }

        public string Subject { get; set; } 

        public string Message {  get; set; }
    }

    
}