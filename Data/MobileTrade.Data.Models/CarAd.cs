namespace MobileTrade.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using MobileTrade.Data.Common.Models;

    public class CarAd : BaseDeletableModel<int>
    {
        public CarAd()
        {
            this.Features = new HashSet<Feature>();
            this.NumberOfViews = 0;
        }

        [Required]
        public int MakeId { get; set; }

        public virtual Make Make { get; set; }

        [Required]
        public int ModelId { get; set; }

        public virtual Model Model { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime ProductionDate { get; set; }

        [Required]
        [Range(1, 10000)]
        public int Power { get; set; }

        [Required]
        public int FuelTypeId { get; set; }

        public virtual FuelType FuelType { get; set; }

        [Required]
        public int TransmissionTypeId { get; set; }

        public virtual TransmissionType TransmissionType { get; set; }

#nullable enable
        public int? Mileage { get; set; }
#nullable disable

        [Required]
        public Condition Condition { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        public int ColorId { get; set; }

        public Color Color { get; set; }

        [Required]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        [Required]
        public int EmissionClassId { get; set; }

        public virtual EmissionClass EmissionClass { get; set; }

#nullable enable
        public virtual IEnumerable<Feature>? Features { get; set; }
#nullable disable

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public int NumberOfViews { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }

#nullable enable
        public string? Description { get; set; }
#nullable disable
    }
}