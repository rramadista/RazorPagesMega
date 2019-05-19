using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMega.Models
{
    public class Office
    {
        public int ID { get; set; }
        [Display(Name = "Branch ID")]
        public int BranchID { get; set; }
        [Display(Name = "Office Name")]
        public string OfficeName { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}
