﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnterCameraLock : BaseAction
    {
        [JsonProperty] public readonly string transName;
        [JsonProperty] public readonly string cfgPath;
    }
}
