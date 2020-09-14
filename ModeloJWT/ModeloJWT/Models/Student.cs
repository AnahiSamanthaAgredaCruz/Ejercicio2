using System;
using System.ComponentModel.DataAnnotations;

namespace ModeloJWT.Models
{
    public class Student
    {
        
        public int StudentID { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "You must enter the filed{0}")]

        public string LastName { get; set; }


        [StringLength(30, ErrorMessage = "The filed{0} must contain betwen {2} and {1} characters", MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter the filed{0}")]

        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }


    }
}