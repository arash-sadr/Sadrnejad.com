using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sadrnejad.com.Models
{
    public class Tag
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Confirmed")]
        public bool Enabled { get; set; }
        public string UrlSlug { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}