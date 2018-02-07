using System;
using System.Collections.Generic;
using System.Text;

namespace refly.Services
{
    public interface IWorldService
    {
        void Load(string storyFile);
        void Create();
        void Destroy();
        void Map();
    }
}
