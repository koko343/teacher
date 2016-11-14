using System;
using Teacher.Core.Entities.Base;

namespace Teacher.Core.Entities
{
    public class Comment : EntityBase
    {
        public string Content { get; set; }

        public DateTime DateTime { get; set; }

        public string UserName { get; set; }
    }
}
