using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using refly.graph;
using refly.core.models;

namespace refly.core.repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private IGraph graph = null;

        public PlayerRepository(IGraph graph)
        {
            this.graph = graph;
        }

        public PlayerModel Get()
        {
            return graph.Match<PlayerModel>("Player", null).FirstOrDefault<PlayerModel>();
        }

        public void Save(PlayerModel player)
        {
            graph.Save<PlayerModel>("Player", player);
        }
    }
}
