namespace MobileTrade.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MobileTrade.Data.Models;

    public class FeatureTypeConfiguration : IEntityTypeConfiguration<FeatureType>
    {
        public void Configure(EntityTypeBuilder<FeatureType> featureType)
        {
            featureType.Property(m => m.Id).ValueGeneratedNever();
        }
    }
}
