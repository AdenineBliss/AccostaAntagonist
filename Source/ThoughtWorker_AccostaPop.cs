using Verse;
using RimWorld;

namespace AddieStorytellers
{
    public class ThoughtWorker_AccostaPop : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            Log.Message("Suffer two");
            if (!p.IsColonist)
            {
                return false;
                return ThoughtState.Inactive;
            }
            
            return true;
            return ThoughtState.Inactive;
            /*
            if (ThoughtUtility.ThoughtNullified(p, def))
            {
                return ThoughtState.Inactive;
            }
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
            */
        }
    }
}