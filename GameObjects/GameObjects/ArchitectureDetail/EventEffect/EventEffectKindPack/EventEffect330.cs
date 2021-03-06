﻿namespace GameObjects.ArchitectureDetail.EventEffect
{
    using GameObjects;
    using System;

    internal class EventEffect330 : EventEffectKind
    {
        private int increment;

        public override void ApplyEffectKind(Person person, Event e)
        {
            GameObjects.PersonDetail.Title title = person.Scenario.GameCommonData.AllTitles.GetTitle(increment);
            foreach (GameObjects.PersonDetail.Title t in person.RealTitles)
            {
                if (t.Kind == title.Kind)
                {
                    title.Influences.PurifyInfluence(person, GameObjects.Influences.Applier.Title, title.ID, false);
                    person.RealTitles.Remove(title);
                }
            }
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

