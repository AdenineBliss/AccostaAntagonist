using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;

namespace AddieStorytellers
{
    public static class AddieStorytellerUtility
    {
        public static bool AccostaAntagonistUtility(Storyteller storyteller)
        {
            return true;
        }

        public static void AccostaAntagonistNoResistance(Pawn_GuestTracker guest)
        {
            if (Find.Storyteller.def == StorytellerDefOf.Addie_AccostaAntagonist)
            {
                guest.resistance = 0;
                guest.Recruitable = true;
            }
        }
    }
}