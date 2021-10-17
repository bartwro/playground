using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server
{
    public class Portfolio
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Position[] Positions { get; set; }
    }
}
