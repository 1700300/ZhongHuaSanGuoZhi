﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind2150 : ConditionKind
    {
        private double val = 0;

        public override bool CheckConditionKind(Architecture a)
        {
            return (double) a.Morale / a.MoraleCeiling >= val;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.val = double.Parse(parameter);
            }
            catch
            {
            }
        }

    }
}

