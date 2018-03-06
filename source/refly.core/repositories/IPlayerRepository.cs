using System;
using System.Collections.Generic;
using System.Text;

using refly.models;

namespace refly.core.repositories
{
    public interface IPlayerRepository
    {
        void Save(PlayerModel story);
        PlayerModel Get(Guid id);
    }
}
