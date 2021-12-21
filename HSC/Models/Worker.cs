namespace HSC.Models
{
    public class Worker
    {
        public string Id { get; set; }
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string callNumber { get; set; }
        public string whatsappNumber { get; set; }
        public string adharChard { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public int pincode { get; set; }
        public string state { get; set; }
        public string image { get; set; }


        public Worker()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
