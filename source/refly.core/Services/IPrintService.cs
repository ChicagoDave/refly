using System;
using System.Collections.Generic;
using System.Text;

namespace refly.Services
{
    public interface IPrintService
    {
        void AddText(string text, string textType);
        void ChangeText();
        void PrintAll();
        void PrintCurrent();
    }
}
