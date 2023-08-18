using BannerKings.Managers.Goals;
using System;
using System.Collections.Generic;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Goals
{
    public class RoyalGuardGoal : Goal
    {
        public RoyalGuardGoal() : base("goal_royal_guard_decision", GoalCategory.Kingdom, GoalUpdateType.Manual)
        {

        }

        public override void DoAiDecision()
        {
            throw new NotImplementedException();
        }

        public override void ApplyGoal()
        {
            throw new NotImplementedException();
        }

        public override bool IsAvailable()
        {
            throw new NotImplementedException();
        }

        public override bool IsFulfilled(out List<TextObject> failedReasons)
        {
            throw new NotImplementedException();
        }

        public override void ShowInquiry()
        {
            throw new NotImplementedException();
        }
    }
}
