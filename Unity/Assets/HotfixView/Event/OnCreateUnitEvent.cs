﻿using ET.EventType;
using ET;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class OnCreateUnitEvent : AEvent<ET.EventType.OnCreateUnit>
    {
        public override async ETTask Run(OnCreateUnit args)
        {
            var unit = args.unit;

            GameObject go = (await ResourceViewHelper.LoadPrefabAsync(args.prefabId)).gameObject;
            unit.AddComponent<UnitView, GameObject>(go);
            unit.AddComponent<PopupComponent>();


            if (unit.Id == GlobalVariable.MyId)
            {
                unit.AddComponent<CameraComponent, float, float>(-15, 15);
            }
            await ETTask.CompletedTask;
        }
    }
}