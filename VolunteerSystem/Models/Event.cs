using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace VolunteerSystem.Models
{
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }

        // foreign key
        public int JobID { get; set; }
        public int VolunteerID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }

      
      
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public string Date { get; set; }

        public virtual Job Jobs { get; set; }
     
        public virtual Volunteer Volunteers { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}