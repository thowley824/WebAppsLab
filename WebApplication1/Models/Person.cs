using System;
using System.ComponentModel.DataAnnotations;



namespace WebApplication1.Models
{ 
    public class Person
    { 
        public int PersonID { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name Should Be Between 2 and 20 Characters Long")]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Birthday { get; set; }
        public int Age { get; set; }
    }
}

