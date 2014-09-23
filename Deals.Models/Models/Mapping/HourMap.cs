using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Deals.Models.Models.Mapping
{
    public class HourMap : EntityTypeConfiguration<Hour>
    {
        public HourMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hours");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SundayOpen).HasColumnName("SundayOpen");
            this.Property(t => t.SundayClose).HasColumnName("SundayClose");
            this.Property(t => t.MondayOpen).HasColumnName("MondayOpen");
            this.Property(t => t.MondayClose).HasColumnName("MondayClose");
            this.Property(t => t.TuesdayOpen).HasColumnName("TuesdayOpen");
            this.Property(t => t.TuesdayClose).HasColumnName("TuesdayClose");
            this.Property(t => t.WednesdayOpen).HasColumnName("WednesdayOpen");
            this.Property(t => t.WednesdayClose).HasColumnName("WednesdayClose");
            this.Property(t => t.ThursdayOpen).HasColumnName("ThursdayOpen");
            this.Property(t => t.ThursdayClose).HasColumnName("ThursdayClose");
            this.Property(t => t.FridayOpen).HasColumnName("FridayOpen");
            this.Property(t => t.FridayClose).HasColumnName("FridayClose");
            this.Property(t => t.SaturdayOpen).HasColumnName("SaturdayOpen");
            this.Property(t => t.SaturdayClose).HasColumnName("SaturdayClose");
        }
    }
}
