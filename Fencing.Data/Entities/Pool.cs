using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Data.Entities
{
    public class Pool
    {
        public Guid Id { get; set; }

        public Guid TournamentId { get; set; }

        public List<Bout> Bouts { get; set; }
    }
}
