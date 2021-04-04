using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinlist.Core.Entities.Lists
{
    [Table("ListItem")]
    public class ListItem
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int Count { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreationTime { get; set; }
        [ForeignKey("ListId")]
        public virtual int ListId { get; set; }
        public virtual List List { get; set; }

    }
}