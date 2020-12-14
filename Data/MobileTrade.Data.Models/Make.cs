namespace MobileTrade.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MobileTrade.Data.Common.Models;

    public class Make : BaseDeletableModel<int>
    {
        public Make()
        {
            this.Models = new HashSet<Model>();
        }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        public virtual IEnumerable<Model> Models { get; set; }
    }
}
