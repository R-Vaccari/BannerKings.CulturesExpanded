using BannerKings.Managers.Goals;
using System.Collections.Generic;

namespace BannerKings.CulturesExpanded.Goals
{
    internal class BKTOGoals : DefaultTypeInitializer<BKTOGoals, Goal>
    {
        public CrownGuardGoal CrownGuard { get; } = new CrownGuardGoal();
        public override IEnumerable<Goal> All
        {
            get
            {
                yield return CrownGuard;
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
