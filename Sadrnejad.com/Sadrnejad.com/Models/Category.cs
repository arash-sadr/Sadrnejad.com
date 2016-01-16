using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sadrnejad.com.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Title")]
        [StringLength(200)]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [StringLength(400)]
        public string Description { get; set; }

        [Display(Name = "Confirmed")]
        public bool Enabled { get; set; }
        public string UrlSlug { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}