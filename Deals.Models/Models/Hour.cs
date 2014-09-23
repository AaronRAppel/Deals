using System;
using System.Collections.Generic;

namespace Deals.Models.Models
{
    public partial class Hour
    {
        public Hour()
        {
            this.Bars = new List<Bar>();
            this.Deals = new List<Deal>();
        }

        public int Id { get; set; }
        public Nullable<System.TimeSpan> SundayOpen { get; set; }
        public Nullable<System.TimeSpan> SundayClose { get; set; }
        public Nullable<System.TimeSpan> MondayOpen { get; set; }
        public Nullable<System.TimeSpan> MondayClose { get; set; }
        public Nullable<System.TimeSpan> TuesdayOpen { get; set; }
        public Nullable<System.TimeSpan> TuesdayClose { get; set; }
        public Nullable<System.TimeSpan> WednesdayOpen { get; set; }
        public Nullable<System.TimeSpan> WednesdayClose { get; set; }
        public Nullable<System.TimeSpan> ThursdayOpen { get; set; }
        public Nullable<System.TimeSpan> ThursdayClose { get; set; }
        public Nullable<System.TimeSpan> FridayOpen { get; set; }
        public Nullable<System.TimeSpan> FridayClose { get; set; }
        public Nullable<System.TimeSpan> SaturdayOpen { get; set; }
        public Nullable<System.TimeSpan> SaturdayClose { get; set; }
        public virtual ICollection<Bar> Bars { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
    }
}
