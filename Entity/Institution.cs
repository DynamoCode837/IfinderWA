using System;
using System.Collections.Generic;
using System.Text;

namespace Ifinder.Entity
{
    public class Institution
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string LogoUrl { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        
        public Location Location { get; set; }
        public Guid LocationId { get; set; }

      
    }
}
