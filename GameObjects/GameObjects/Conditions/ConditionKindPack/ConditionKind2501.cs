﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind2501 : ConditionKind
    {
        public override bool CheckConditionKind(Architecture a)
        {
            return !a.FrontLine;
        }

    }
}

