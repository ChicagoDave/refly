using System;
using System.Collections.Generic;
using System.Text;

using refly.core.repositories;
using refly.models;

namespace refly.core.services
{
    public class PlayerService : IPlayerService
    {
        private IPlayerRepository playerRepository = null;

        public PlayerService(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public PlayerModel Get(string name)
        {
            return new PlayerModel();
        }

        public void Save(PlayerModel player)
        {
            throw new NotImplementedException();
        }
    }
}
