using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter the First Address Line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please Enter Zip")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please Enter Country")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
