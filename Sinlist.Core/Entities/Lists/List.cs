using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinlist.Core.Entities.Lists
{
    [Table("List")]
    public class List
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual bool IsActive { get; set; }
    }
}