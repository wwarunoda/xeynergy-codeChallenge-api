using System.Data.Entity.ModelConfiguration;
namespace xeynergy_codeChallenge_api.Entities
{
    public class PersonConfigurations : EntityTypeConfiguration<Person>
    {
        public PersonConfigurations()
        {
            this.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            this.Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(100);
            this.Property(s => s.EmailAddress)
                .IsOptional()                
                .HasMaxLength(100);
        }
    }
}
