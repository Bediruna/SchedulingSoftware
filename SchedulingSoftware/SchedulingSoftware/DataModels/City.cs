using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware.DataModels
{
    public class City
    {

        public int cityId { get; set; }
        public string city { get; set; }
        public int countryId { get; set; }
        public string createdBy { get; set; }
    }
}
