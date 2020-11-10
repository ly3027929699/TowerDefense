﻿using System;
using System.Collections.Generic;

namespace ET
{
    public class TargetComponentAwakeSystem : AwakeSystem<TargetComponent>
    {
        public override void Awake(TargetComponent self)
        {
            self.Awake();
        }
    }
    public class TargetComponent : Entity
    {
        private List<Unit> targets = new List<Unit>();

        internal void Awake()
        {

        }
        public void AddTrigger(Unit unit, Action<Unit> onEnter, Action<Unit> onExit)
        {
            Game.EventSystem.Publish_Sync(new ET.EventType.AddTrigger
            {
                unit = unit,
                onEnter = onEnter,
                onExit = onExit
            });
        }
        public void AddTarget(Unit unit)
        {
            targets.Add(unit);
        }
        public int TargetCount => targets.Count;
        public Unit GetFirst()
        {

            if (targets.Count <= 0)
                return null;
            int i = targets.Count;
            while (--i >= 0)
            {
                var unit = targets[i];
                if (unit.IsAlive)
                    return unit;
                else
                    targets.Remove(unit);
            }
            return null;
        }

        public void RemoveTraget(Unit unit)
        {
            targets.Remove(unit);
        }
    }
}
