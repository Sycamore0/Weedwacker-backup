using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("BlossomChestExcelConfigData.json")]
    internal class BlossomChestData
    {
        [JsonProperty] public readonly uint id;
        [JsonProperty] public readonly uint chestGadgetId;
        [JsonProperty] public readonly uint worldResin;
        [JsonProperty] public readonly uint resin;
        [JsonProperty] public readonly BlossomRefreshType refreshType;
        [JsonProperty] public readonly BlossomChestShowType clientShowType;
    }
}
