namespace HSC.Models
{
    public class Vehicle
    {
        public string Id { get; set; }
        public string Number { get; set; }
        public int kmPrice { get; set; }
        public string owner { get; set; }

        public Vehicle()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
