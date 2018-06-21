using Fencing.Core.Enums;
using Fencing.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Service.Interfaces
{
    public interface ITournamentService
    {
        Guid CreateTournament(string name, WeaponType weaponType);
    }
}
