using OOPAdventure.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdventure.Actions
{
    public class Go : Action
    {
        public override string Name => Text.Language.Go;
        private readonly House _house;
        public Go(House house)
        {
            _house = house;
        }

    }
}
