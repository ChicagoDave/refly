using System;
using System.Collections.Generic;
using System.Text;

namespace refly.Services
{
    public interface ICharacterService
    {
        void Action();
        void Speak();
        void Listen();
        void Smell();
        void Touch();
        void View();
    }
}
