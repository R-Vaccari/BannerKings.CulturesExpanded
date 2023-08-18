using BannerKings.Managers.Goals;
using System.Collections.Generic;

namespace BannerKings.CulturesExpanded.Goals
{
    internal class BKTOGoals : DefaultTypeInitializer<BKTOGoals, Goal>
    {
        public RoyalGuardGoal Royal { get; } = new RoyalGuardGoal();
        public override IEnumerable<Goal> All
        {
            get
            {
                yield return Royal;
            }
        }

        public override void Initialize()
        {
            foreach (Goal goal in All)
            {
                DefaultGoals.Instance.AddObject(goal);
            }
        }
    }
}
