using System;
using System.Collections.Generic;
using System.Text;

namespace Ifinder.Entity
{
   public  class Province
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public City City { get; set; }
        public Guid CityId { get; set; }
    }
}
