using System;
using System.Collections.Generic;

namespace Deals.Models.Models
{
    public partial class Deal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> HoursId { get; set; }
        public virtual Hour Hour { get; set; }
    }
}
