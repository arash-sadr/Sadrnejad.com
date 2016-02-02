using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sadrnejad.com.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}