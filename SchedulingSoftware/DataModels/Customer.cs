﻿namespace SchedulingSoftware.DataModels
{
    public class Customer
    {

        public int customerId { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public bool active { get; set; }
        public string createdBy { get; set; }

    }
}
