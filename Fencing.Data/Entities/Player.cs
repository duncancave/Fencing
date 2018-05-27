using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Data.Entities
{
    public class Player
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public int Rank { get; set; }
    }
}
