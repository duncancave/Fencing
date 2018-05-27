using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Data.Entities
{
    public class PoolResult
    {
        public Guid Id { get; set; }

        public Guid PlayerId { get; set; }

        public int Victories { get; set; }

        public int HitsFor { get; set; }

        public int HitsAgainst { get; set; }

        public int Indicator { get; set; }

        public int Place { get; set; }
    }
}
