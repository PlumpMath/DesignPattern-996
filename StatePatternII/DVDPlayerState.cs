using System;
using System.Collections.Generic;
using System.Linq;

namespace StatePatternII
{
    public abstract class DVDPlayerState
    {
        public abstract void PlayButtonPressed(DVDPlayer player);

        public abstract void MenuButtonPressed(DVDPlayer player);
    }
}
