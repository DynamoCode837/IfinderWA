using System;
using System.Collections.Generic;
using System.Text;

namespace Ifinder.Entity
{
    public class Faculty
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int ApsScore { get; set; }

        public FacultySemester FacultySemester { get; set; }
        public Guid FacultySemesterId { get; set; }

        public Institution Institution { get; set; }
        public Guid InstitutionId { get; set; }
    }
}
