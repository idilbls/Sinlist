using System;
using System.Collections.Generic;
using System.Text;

namespace Sinlist.Shared.Lists
{
    public class ListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
    }
}