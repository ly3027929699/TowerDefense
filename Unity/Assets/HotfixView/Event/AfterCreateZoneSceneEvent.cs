﻿using ET.EventType;
using ET;
using System;
using System.Collections.Generic;

namespace ET
{
    public class AfterCreateZoneSceneEvent : AEvent<AfterCreateZoneScene>
    {
        public override async ETTask Run(AfterCreateZoneScene args)
        {
            var zoneScene = args.zoneScene;

            zoneScene.AddComponent<UIEventComponent>();
            zoneScene.AddComponent<GameObjectPool>();
            zoneScene.AddComponent<FUIPackageComponent>();
            zoneScene.AddComponent<FUIComponent>();
            zoneScene.AddComponent<FUIInitComponent>();

            zoneScene.AddComponent<TransPointComponent>();
            zoneScene.AddComponent<TranslateSceneComponent>();
            zoneScene.AddComponent<HudComponent>();
            zoneScene.AddComponent<NPCHudComponent>();
            zoneScene.AddComponent<ShopComponent>();

            Game.EventSystem.Publish(new ET.EventType.InitSceneEnd
            {
                zoneScene = zoneScene
            }).Coroutine();
            await ETTask.CompletedTask;
        }
    }
}