using System;
using System.Collections.Generic;
using System.Text;

using refly.models;

namespace refly.core.services
{
    public interface IPlayerService
    {
        PlayerModel Get(string name);
        void Save(PlayerModel player);
    }
}
