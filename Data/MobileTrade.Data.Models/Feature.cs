namespace MobileTrade.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using MobileTrade.Data.Common.Models;

    public class Feature : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int FeatureTypeId { get; set; }

        public virtual FeatureType FeatureType { get; set; }
    }
}
