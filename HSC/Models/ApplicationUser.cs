using Microsoft.AspNetCore.Identity;

namespace HSC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string callNumber { get; set; }
        public string whatsappNumber { get; set; }
        public string adharCard { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string pincode { get; set; }
        public string state { get; set; }
        public string image { get; set; }
    }
}
