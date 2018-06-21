using Fencing.Core.Enums;
using Fencing.Service;
using Fencing.Service.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing.Test
{
    [TestClass]
    public class ServiceTests
    {
        private ITournamentService TournamentService { get; set; }

        private IPoolService PoolService { get; set; }

        [TestInitialize]
        public void Setup()
        {
            this.TournamentService = new TournamentService();
            this.PoolService = new PoolService();
        }

        [TestMethod]
        public void CreateTournament()
        {
            // Arrange
            // Act
            var tournamentId = this.TournamentService.CreateTournament("Test", WeaponType.Epee);

            // Assert
            Assert.IsNotNull(tournamentId);
            Assert.AreNotEqual(new Guid(), tournamentId);
        }

        [TestMethod]
        public void ValidPool()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
