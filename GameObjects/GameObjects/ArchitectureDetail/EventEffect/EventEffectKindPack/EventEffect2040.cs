﻿namespace GameObjects.ArchitectureDetail.EventEffect
{
    using GameObjects;
    using System;

    internal class EventEffect2040 : EventEffectKind
    {
        private int increment;

        public override void ApplyEffectKind(Faction f, Event e)
        {
            f.BaseMilitaryKinds.AddMilitaryKind(f.Scenario.GameCommonData.AllMilitaryKinds.GetMilitaryKind(increment));
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

