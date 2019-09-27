using System;
using System.ComponentModel.DataAnnotations;

namespace Evaluation.Models
{
    public enum TypeGender { Male, Female, Other }

    public class Student
    {
        [Key]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.Date)] 
        public DateTime Birthdate { get; set; }
        
        [Required]
        public TypeGender Gender { get; set; }
    }
}