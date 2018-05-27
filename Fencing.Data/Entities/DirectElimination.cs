using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Data.Entities
{
    public class DirectElimination
    {
        public Guid Id { get; set; }

        public int NoOfPeriods { get; set; }

        public int PeriodLength { get; set; }

        public int MaxLength { get; set; }

        public List<Round> Rounds { get; set; }

        public Guid TournamentId { get; set; }
    }
}
