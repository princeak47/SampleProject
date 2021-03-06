//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JqueryDataTableWithoutModal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Person
    {
        [Required(ErrorMessage = "Email Id Required")]
        [EmailAddress(ErrorMessage = "Invalid Email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This Field Required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public Nullable<decimal> Mobile { get; set; }
        [Required(ErrorMessage = "This Field Required")]
        [Range(1, 100)]
        public Nullable<byte> Age { get; set; }
        [Required(ErrorMessage = "This Field Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DOB { get; set; }
        [Required(ErrorMessage = "This Field Required")]
        public string Location { get; set; }
        public int id { get; set; }
        [Required(ErrorMessage = "This Field Required")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This Field Required")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
    }
}
