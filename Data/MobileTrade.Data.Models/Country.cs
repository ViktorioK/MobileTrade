namespace MobileTrade.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using MobileTrade.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }
    }
}
