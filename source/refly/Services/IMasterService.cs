using System;
using System.Collections.Generic;
using System.Text;

namespace refly.Services
{
    public interface IMasterService
    {
        int CurrentTurn { get; set; }
        void Initialize(string storyFile);
        void Save();
        void Restore();
    }
}
