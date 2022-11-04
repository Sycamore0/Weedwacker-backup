﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ReplaceEventPatternMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] oldPatterns;
        [JsonProperty] public readonly string[] newPatterns;
    }
}
