using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ejercicioo2.Models
{
    public class Enrollment
    {
        public enum Grade
        {
            A, B, C, D, F
        }
        [Key]
        public int EnrollmentID { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        private Grade? grade;

        public Grade? GetGrade()
        {
            return grade;
        }

        public void SetGrade(Grade? value)
        {
            grade = value;
        }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

        
    }
}
