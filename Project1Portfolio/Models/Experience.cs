//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project1Portfolio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Experience
    {
        public int ExperienceId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string WorkDate { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
