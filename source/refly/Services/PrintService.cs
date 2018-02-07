using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refly.Services
{
    /// <summary>
    /// The logic of the print service will be such that text can be added by type,
    /// then injected into a template. This template may simply emit to the console,
    /// or it may emit to some other display type.
    /// </summary>
    public class PrintService : IPrintService
    {
        private List<Snippet> snippets = new List<Snippet>();
        private List<string> textTypes = new List<string>();

        private IMasterService masterService = null;

        private PrintService(IMasterService masterService)
        {
            this.masterService = masterService;

            textTypes.Add("prologue");
            textTypes.Add("score");
            textTypes.Add("location");
            textTypes.Add("time");
            textTypes.Add("prompt");
            textTypes.Add("before-notice");
            textTypes.Add("after-notice");
            textTypes.Add("main-content");
        }

        public void AddText(string text, string textType)
        {
            var checkType = (from tt in textTypes where tt == textType select tt).FirstOrDefault<string>();

            // Add the new text type to the list
            if (checkType == null || checkType == "")
            {
                textTypes.Add(textType);
            }

            int turn = masterService.CurrentTurn();


        }

        public void ChangeText()
        {
            throw new NotImplementedException();
        }

        public void PrintAll()
        {
            throw new NotImplementedException();
        }

        public void PrintCurrent()
        {
            throw new NotImplementedException();
        }

        private class Snippet
        {
            private string Text { get; set; }
            private string TextType { get; set; }

            public Snippet(string text, string textType)
            {
                this.Text = text;
                this.TextType = textType;
            }
        }
    }

}
