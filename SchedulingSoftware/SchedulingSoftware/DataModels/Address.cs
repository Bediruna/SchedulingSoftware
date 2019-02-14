namespace SchedulingSoftware.DataModels
{
    public class Address
    {
        public int addressId { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public string postalCode { get; set; }
        
        public string phone { get; set; }

        public string createdBy { get; set; }

    }
}
