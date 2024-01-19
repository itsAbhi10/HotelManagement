using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURDusingEF.Models
{
    [Table("CustomerRoombooking")]
    public class BookingModel
    {

            [Key]
            public string RoomNumber { get; set; }

            public string CustomerName { get; set; }

            public Int64 MobileNo { get; set; }

            public int Adult { get; set; }

            public int ChildrenCount { get; set; }

            public string RoomType { get; set; }

            public Int64 AadharNo { get; set; }

            public DateTime CheckIn { get; set; }
            public DateTime CheckOut { get; set; }


    }
}

