using Verse;
using RimWorld;

namespace AddieStorytellers
{
    public class ThoughtSituational_AccostaPop : Thought_Situational
    {
        public const int NumPawns_Alone = 1;

        public const int NumPawns_NotCrowded = 3;

        public const int NumPawns_Inactive = 7;

        public const int NumPawns_Crowded = 15;

        private static readonly SimpleCurve MoodOffsetCurveFromPopulation = new SimpleCurve
        {
            new CurvePoint(1f, 12f),
            new CurvePoint(2f, 8f),
            new CurvePoint(3f, 6f),
            new CurvePoint(4f, -4f),
            new CurvePoint(5f, -7f),
            new CurvePoint(10f, -10f),
            new CurvePoint(11f, -20f),
            new CurvePoint(12f, -30f),
            new CurvePoint(13f, -40f),
            new CurvePoint(14f, -50f),
            new CurvePoint(15f, -60f),
            new CurvePoint(16f, -80f)
        };

        public override float MoodOffset()
        {
            int freeColonistsAndPrisonersSpawnedCount = pawn.Map.mapPawns.FreeColonistsAndPrisonersSpawnedCount;
            return MoodOffsetCurveFromPopulation.Evaluate(freeColonistsAndPrisonersSpawnedCount);
        }
    }
}
