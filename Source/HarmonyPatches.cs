using HarmonyLib;
using RimWorld;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UnityEngine;
using Verse;
using Verse.AI;

namespace AddieStorytellers
{
    [StaticConstructorOnStartup]
    static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            Harmony harmony = new Harmony("Addie.AddieStorytellers");

            harmony.Patch(AccessTools.Method(typeof(Pawn_GuestTracker), "GuestTrackerTick"),
                 null, new HarmonyMethod(typeof(HarmonyPatches), nameof(AccostaResistance_Post)));

            harmony.Patch(AccessTools.Method(typeof(MentalBreakWorker), "CommonalityFor"),
                null, new HarmonyMethod(typeof(HarmonyPatches), nameof(AccostaMentalBreak_Post)));

        }

        public static void AccostaResistance_Post(Pawn_GuestTracker __instance)
        {
            Storyteller storyteller = Current.Game.storyteller;

            if (storyteller.def == StorytellerDefOf.Addie_AccostaAntagonist)
            {
                if (__instance.GuestStatus != GuestStatus.Prisoner) { return; }
                Traverse traverse = Traverse.Create(__instance);
                traverse.Field("resistance").SetValue(0f);
                traverse.Field("recruitable").SetValue(true);
            }
        }

        static void AccostaMentalBreak_Post(ref float __result)
        {
            Storyteller storyteller = Current.Game.storyteller;
            if (storyteller.def == StorytellerDefOf.Addie_AccostaAntagonist)
            {
                __result *= 5;
                Log.Message("Result: " + __result);
            }
        }

    }
}