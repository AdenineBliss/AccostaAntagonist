using Verse;
using RimWorld;

namespace AddieStorytellers
{
    public class ThoughtWorker_AccostaPop : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            if (!p.IsColonist || p.MapHeld == null) return ThoughtState.Inactive;

            if (Current.Game?.storyteller?.def?.defName == DefOfs.Addie_AccostaAntagonist.defName)
            {
                int freeColonistsAndPrisonersSpawnedCount = p.Map.mapPawns.FreeColonistsAndPrisonersSpawnedCount;
                if (freeColonistsAndPrisonersSpawnedCount <= 1)
                {
                    return ThoughtState.ActiveAtStage(0);
                }
                if (freeColonistsAndPrisonersSpawnedCount <= 3)
                {
                    return ThoughtState.ActiveAtStage(1);
                }
                if (freeColonistsAndPrisonersSpawnedCount <= 7)
                {
                    return ThoughtState.ActiveAtStage(2);
                }
                if (freeColonistsAndPrisonersSpawnedCount <= 15)
                {
                    return ThoughtState.ActiveAtStage(3);
                }
                return ThoughtState.ActiveAtStage(3);
            }
            return ThoughtState.Inactive;

        }
    }
}
