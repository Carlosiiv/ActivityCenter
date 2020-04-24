using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    
    public class FutureDate : ValidationAttribute
    {
    public override string FormatErrorMessage(string name)
    {
        return "Date should be a future date";
    }

    protected override ValidationResult IsValid(object objValue,
                                                   ValidationContext validationContext)
    {
        var dateValue = objValue as DateTime? ?? new DateTime();

        //alter this as needed. I am doing the date comparison if the value is not null

        if (dateValue.Date < DateTime.Now.Date)
        {
           return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }
        return ValidationResult.Success;
    }
    }
    
    public class Activ
    {
        [Key]
        public int ActivityId {get;set;}

        [Required]
        public string Title {get;set;}

        [Required]
        [DataType(DataType.Date)]
        [FutureDate]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date {get;set;} 

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:MM}", ApplyFormatInEditMode = true)]
        public DateTime Time{get;set;}

        [Required]
        public int Duration{get;set;}
        [Required]
        public string DurationTimeset{get;set;}

        [Required]
        public string Description{get;set;}
        

        public int UserId{get;set;}

        public User Creator{get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now; //<-----Add This

        public DateTime UpdatedAt { get; set; } = DateTime.Now;//<-----Add This

        public List<Association> Users{get;set;}

        public int Participants(){
            return Users.Count;
        }
    }
}