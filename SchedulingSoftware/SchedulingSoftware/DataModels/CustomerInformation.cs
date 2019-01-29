using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware.DataModels
{
    public class CustomerInformation
    {       
        public int customerID { get; set; }
        public string customerName { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }

        public string phone { get; set; }

        public CustomerInformation()
        {
            
        }

        public CustomerInformation(string _customerName, string _address, string _address2, string _city, string _postalCode, string _country, string _phone)
        {
            customerName = _customerName;
            address = _address;
            address2 = _address2;
            city = _city;
            postalCode = _postalCode;
            country = _country;
            phone = _phone;
        }

    }

}
