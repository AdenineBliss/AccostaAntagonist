﻿using RimWorld;

namespace AddieStorytellers
{
    [DefOf]
    public static class StorytellerDefOf
    {
        public static StorytellerDef Addie_AccostaAntagonist;

        static StorytellerDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(StorytellerDefOf));
        }

    }
}