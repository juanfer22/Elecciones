
namespace Elections.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Event
    {
        
            public int Id { get; set; }
            [MaxLength(50)]
        [Required]
        public string Name { get; set; }

            [Display(Name = "Last Purchase")]
            public DateTime? LastPurchase { get; set; }
          

            [Display(Name = "Is Availabe?")]
            public bool IsAvailabe { get; set; }

            [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
            public double Stock { get; set; }

            public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

            public String Candidates { get; set; }
    }
}
