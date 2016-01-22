using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Sadrnejad.com.Models
{
    public class Post
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Title")]
        [StringLength(300)]
        public string Title { get; set; }

        [Display(Name = "Short Description")]
        [StringLength(1000)]
        public string ShortDescription { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml, Display(Name = "Body")]
        public string Article { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }

        [Display(Name = "Publish it")]
        public bool Published { get; set; }

        [Required]
        [Display(Name = "Post date")]
        public DateTime PostedOn { get; set; }

        [Required]
        [Display(Name = "Modification date")]
        public DateTime? Modified { get; set; }

        [ForeignKey("Categories")]
        [Display(Name = "Category")]
        public int Category_ID { get; set; }
        public virtual Category Categories { get; set; }

        public virtual IList<Tag> Tags { get; set; }
        public virtual IList<Author> Authors { get; set; }
    }
}