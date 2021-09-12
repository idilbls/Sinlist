using System;
using System.Collections.Generic;
using System.Text;

namespace Sinlist.Shared.Lists
{
    public class ListItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
        public int ListId { get; set; }
    }
}