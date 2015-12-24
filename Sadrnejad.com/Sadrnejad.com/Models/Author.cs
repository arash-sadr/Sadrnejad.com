using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sadrnejad.com.Models
{
    public class Author
    {
        public virtual int ID { get; set; }

        public virtual string Name { get; set; }

        public virtual string LastName { get; set; }
        

        public virtual IList<Post> Posts { get; set; }
    }
}