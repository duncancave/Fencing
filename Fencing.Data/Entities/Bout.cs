using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Data.Entities
{
    public class Bout
    {
        public Guid Id { get; set; }

        public Guid PoolId { get; set; }

        public Guid BoutPlayer1Id { get; set; }

        public Guid BoutPlayer2Id { get; set; }

        public Guid BoutWinnerId { get; set; }
    }
}
