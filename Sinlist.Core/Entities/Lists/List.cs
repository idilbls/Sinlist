using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinlist.Core.Entities.Lists
{
    [Table("List")]
    public class List
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsActive { get; set; }
    }
}