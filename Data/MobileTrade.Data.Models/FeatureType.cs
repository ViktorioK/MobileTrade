namespace MobileTrade.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MobileTrade.Data.Common.Models;

    public class FeatureType : BaseDeletableModel<int>
    {
        public FeatureType()
        {
            this.Features = new HashSet<Feature>();
        }

        [Required]
        public string Name { get; set; }

        public virtual IEnumerable<Feature> Features { get; set; }
    }
}
