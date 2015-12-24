using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sadrnejad.com.Models
{
    public class Tag
    {
        public virtual int ID { get; set; }

        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual bool Enabled { get; set; }

        public virtual string UrlSlug { get; set; }


        public virtual IList<Post> Posts { get; set; }
    }
}