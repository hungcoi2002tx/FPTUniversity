using System;
using System.Collections.Generic;

namespace UniversityLibrary.Models
{
    public enum Grade 
    { 
        A,B, C, D, F
    }
    public partial class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
