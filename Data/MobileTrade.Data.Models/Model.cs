namespace MobileTrade.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using MobileTrade.Data.Common.Models;

    public class Model : BaseDeletableModel<int>
    {
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        public int MakeId { get; set; }

        public virtual Make Make { get; set; }
    }
}
