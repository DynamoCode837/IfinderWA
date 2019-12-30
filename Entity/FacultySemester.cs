using System;
using System.Collections.Generic;
using System.Text;

namespace Ifinder.Entity
{
   public class FacultySemester
    {
        public Guid Id { get; set; }
        public int Semester { get; set; }

        public FacultyModule FacultyModule { get; set; }
        public Guid FacultyModuleId { get; set; }

    }
}
