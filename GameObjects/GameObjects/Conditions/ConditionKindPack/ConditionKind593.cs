﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind593 : ConditionKind
    {
        public override bool CheckConditionKind(Person person)
        {
            return (person.RoutCount < person.RoutedCount);
        }
    }
}

