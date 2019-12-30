using System;
using System.Collections.Generic;
using System.Text;

namespace Ifinder.Entity
{
   public class Location
    {
        public Guid Id { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public City City { get; set; }
        public Guid CityId { get; set; }
        public Province Province { get; set; }
        public Guid ProvinceId { get; set; }


    }
}
