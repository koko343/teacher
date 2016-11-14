using System;
using System.Collections.Generic;
using Teacher.Core.Entities.Base;

namespace Teacher.Core.Entities
{
    public class Article : EntityBase
    {
        public string Title { get; set; }

        public DateTime DateTime { get; set; }

        public string Content { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
