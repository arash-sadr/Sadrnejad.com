using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sadrnejad.com.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Article { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }

        [ForeignKey("Categories")]
        public int Category_ID { get; set; }
        public virtual Category Categories { get; set; }

        [ForeignKey("Tags")]
        public int Tag_ID { get; set; }
        public virtual IList<Tag> Tags { get; set; }

        [ForeignKey("Authors")]
        public int Author_ID { get; set; }
        public virtual IList<Author> Authors { get; set; }
    }
}