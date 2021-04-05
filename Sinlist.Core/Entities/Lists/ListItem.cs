using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinlist.Core.Entities.Lists
{
    [Table("ListItem")]
    public class ListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
        [ForeignKey("ListId")]
        public int ListId { get; set; }
        public List List { get; set; }

    }
}