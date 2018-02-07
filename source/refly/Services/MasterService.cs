using System;
using System.Collections.Generic;
using System.Text;

namespace refly.Services
{
    public class MasterService : IMasterService
    {
        public int CurrentTurn { get; set; }

        private IWorldService worldService = null;
        private ICharacterService characterService = null;
        private ILanguageService languageService = null;
        private IParserService parserService = null;
        private IPrintService printService = null;

        public MasterService(
                IWorldService worldService,
                ICharacterService characterService,
                ILanguageService languageService,
                IParserService parserService,
                IPrintService printService
            )
        {
            this.worldService = worldService;
            this.characterService = characterService;
            this.languageService = languageService;
            this.parserService = parserService;
            this.printService = printService;
        }

        public void Initialize(string storyFile)
        {
            worldService.Load(storyFile);
        }

        public void Restore()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
