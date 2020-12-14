namespace MobileTrade.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using MobileTrade.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }
    }
}
