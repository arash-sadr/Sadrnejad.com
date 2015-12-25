using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sadrnejad.com.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        [ForeignKey("Posts")]
        public int Post_ID { get; set; }
        public virtual IList<Post> Posts { get; set; }
    }
}