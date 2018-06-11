using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using refly.graph.core;
using refly.graph;
using refly.models;

namespace refly.core.repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private IGraph graph = null;

        public PlayerRepository(IGraph graph)
        {
            this.graph = graph;
        }

        public PlayerModel Get(Guid id)
        {
            return graph.Match<PlayerModel>("Player", id,  null).FirstOrDefault<PlayerModel>();
        }

        public void Save(PlayerModel player)
        {
            if (player.Id == null)
            {
                graph.Create<PlayerModel>("Player", player, null);
                return;
            }

            PlayerModel current = Get((Guid)player.Id);

            graph.Set<PlayerModel>("Player", player, null);
        }
    }
}
