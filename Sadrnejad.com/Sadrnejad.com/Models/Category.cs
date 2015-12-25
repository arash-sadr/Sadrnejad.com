using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sadrnejad.com.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public string UrlSlug { get; set; }

        [ForeignKey("Posts")]
        public int Post_ID { get; set; }
        public virtual IList<Post> Posts { get; set; }
    }
}