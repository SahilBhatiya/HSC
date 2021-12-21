using System.ComponentModel.DataAnnotations;

namespace HSC.Models
{
    public class Vehicle
    {
        public string Id { get; set; }

        [Display(Name = "Number")]
        public string Number { get; set; }

        [Display(Name = "Price / KM")]
        public int kmPrice { get; set; }

        [Display(Name = "Owner")]
        public string owner { get; set; }

        public Vehicle()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
