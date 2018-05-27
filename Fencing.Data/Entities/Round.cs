using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Data.Entities
{
    public class Round
    {
        public Guid Id { get; set; }

        public List<Bout> Bouts { get; set; }

        public Guid DirectEliminationId { get; set; }
    }
}
