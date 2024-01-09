using System.ComponentModel.DataAnnotations;

namespace MvcMovies.Models
{
    public class EntityBase
    {
        [Display(Name = "Created Date")]
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

    }
}
