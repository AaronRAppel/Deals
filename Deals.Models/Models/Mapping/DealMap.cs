using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Deals.Models.Models.Mapping
{
    public class DealMap : EntityTypeConfiguration<Deal>
    {
        public DealMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Deals");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.HoursId).HasColumnName("HoursId");

            // Relationships
            this.HasOptional(t => t.Hour)
                .WithMany(t => t.Deals)
                .HasForeignKey(d => d.HoursId);

        }
    }
}
