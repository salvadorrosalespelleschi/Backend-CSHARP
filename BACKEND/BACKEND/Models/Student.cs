﻿namespace BACKEND.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Student
    {
        [Key]
        [Required]
        [Range(1, 9999)]
        public int StudentID { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string LastName { get; set; }
        [StringLength(30, ErrorMessage = "The field {0} must be contained between {2} and {1} characters", MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode = false)]
        public DateTime EnrollmentDate { get; set; }
    }
}