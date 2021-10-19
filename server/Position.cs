using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server
{
    public class Position
    {
        [Required]
        [StringLength(5)]
        public string StockSymbol { get; set; }

        [Required]
        public int Units { get; set; }
    }
}
