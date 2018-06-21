using Fencing.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Data.Entities
{
    public class Tournament
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public WeaponType WeaponType { get; set; }
    }
}
