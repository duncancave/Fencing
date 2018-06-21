using Fencing.Core.Enums;
using Fencing.Data.Entities;
using Fencing.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Service
{
    public class TournamentService : ITournamentService
    {
        public Guid CreateTournament(string name, WeaponType weaponType)
        {
            var tournament = new Tournament
            {
                Id = Guid.NewGuid(),
                Name = name,
                WeaponType = weaponType
            };

            return tournament.Id;
        }
    }
}
