// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VirtualItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VirtualItem.proto</summary>
  public static partial class VirtualItemReflection {

    #region Descriptor
    /// <summary>File descriptor for VirtualItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VirtualItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFWaXJ0dWFsSXRlbS5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90byqZFQoLVmlydHVhbEl0ZW0SHQoZVklSVFVBTF9JVEVNX1ZJUlRV",
            "QUxfTk9ORRAAEiMKH1ZJUlRVQUxfSVRFTV9WSVJUVUFMX0FWQVRBUl9FWFAQ",
            "ZRIjCh9WSVJUVUFMX0lURU1fVklSVFVBTF9QTEFZRVJfRVhQEGYSIwofVklS",
            "VFVBTF9JVEVNX1ZJUlRVQUxfRkVUVEVSX0VYUBBpEh4KGlZJUlRVQUxfSVRF",
            "TV9WSVJUVUFMX1JFU0lOEGoSJgoiVklSVFVBTF9JVEVNX1ZJUlRVQUxfTEVH",
            "RU5EQVJZX0tFWRBrEicKI1ZJUlRVQUxfSVRFTV9WSVJUVUFMX0FTVEVSX1BS",
            "T0dSRVNTEGwSJQohVklSVFVBTF9JVEVNX1ZJUlRVQUxfQVNURVJfQ1JFRElU",
            "EG0SJAogVklSVFVBTF9JVEVNX1ZJUlRVQUxfQVNURVJfVE9LRU4QbhIrCidW",
            "SVJUVUFMX0lURU1fVklSVFVBTF9TSElNTUVSSU5HX0VTU0VOQ0UQbxIlCiFW",
            "SVJUVUFMX0lURU1fVklSVFVBTF9XQVJNX0VTU0VOQ0UQcBIpCiVWSVJUVUFM",
            "X0lURU1fVklSVFVBTF9XT05EUk9VU19FU1NFTkNFEHESKwonVklSVFVBTF9J",
            "VEVNX1ZJUlRVQUxfVFJFQVNVUkVfTUFQX1RPS0VOEHISJgoiVklSVFVBTF9J",
            "VEVNX1ZJUlRVQUxfU0VBX0xBTVBfQ09JThBzEiwKKFZJUlRVQUxfSVRFTV9W",
            "SVJUVUFMX1NFQV9MQU1QX1BPUFVMQVJJVFkQdBIoCiRWSVJUVUFMX0lURU1f",
            "VklSVFVBTF9NRUNIQU5JQ1VTX0NPSU4QdRIqCiZWSVJUVUFMX0lURU1fVklS",
            "VFVBTF9GTEVVUl9GQUlSX0NSRURJVBB2EikKJVZJUlRVQUxfSVRFTV9WSVJU",
            "VUFMX0ZMRVVSX0ZBSVJfVE9LRU4QdxIqCiZWSVJUVUFMX0lURU1fVklSVFVB",
            "TF9XQVRFUl9TUElSSVRfQ09JThB4EiEKHVZJUlRVQUxfSVRFTV9WSVJUVUFM",
            "X0hPTUVfRVhQEHkSLgoqVklSVFVBTF9JVEVNX1ZJUlRVQUxfQ0hBTk5FTExF",
            "Ul9TTEFCX1RPS0VOEHoSKwonVklSVFVBTF9JVEVNX1ZJUlRVQUxfSElERV9B",
            "TkRfU0VFS19DT0lOEHsSLworVklSVFVBTF9JVEVNX1ZJUlRVQUxfU1VNTUVS",
            "X1RJTUVfRFJBRlRfV09PRBB8EjMKL1ZJUlRVQUxfSVRFTV9WSVJUVUFMX1NV",
            "TU1FUl9USU1FX01JTklfSEFSUEFTVFVNEH0SLgoqVklSVFVBTF9JVEVNX1ZJ",
            "UlRVQUxfQk9VTkNFX0NPTkpVUklOR19DT0lOEH4SKgomVklSVFVBTF9JVEVN",
            "X1ZJUlRVQUxfQkxJVFpfUlVTSF9DT0lOX0EQfxIrCiZWSVJUVUFMX0lURU1f",
            "VklSVFVBTF9CTElUWl9SVVNIX0NPSU5fQhCAARIjCh5WSVJUVUFMX0lURU1f",
            "VklSVFVBTF9DSEVTU19FWFAQgQESJAofVklSVFVBTF9JVEVNX1ZJUlRVQUxf",
            "Q0hFU1NfQ09JThCCARIuCilWSVJUVUFMX0lURU1fVklSVFVBTF9MVU5BX1JJ",
            "VEVfQVRNT1NQSEVSRRCDARIqCiVWSVJUVUFMX0lURU1fVklSVFVBTF9ST0dV",
            "RUxJS0VfQ09JTl9BEIQBEioKJVZJUlRVQUxfSVRFTV9WSVJUVUFMX1JPR1VF",
            "TElLRV9DT0lOX0IQhQESKgolVklSVFVBTF9JVEVNX1ZJUlRVQUxfUk9HVUVM",
            "SUtFX0NPSU5fQxCGARIsCidWSVJUVUFMX0lURU1fVklSVFVBTF9XSU5URVJf",
            "Q0FNUF9DT0lOX0EQhwESLAonVklSVFVBTF9JVEVNX1ZJUlRVQUxfV0lOVEVS",
            "X0NBTVBfQ09JTl9CEIgBEi0KKFZJUlRVQUxfSVRFTV9WSVJUVUFMX0xBTlRF",
            "Uk5fUklURV9DT0lOX0EQiQESLQooVklSVFVBTF9JVEVNX1ZJUlRVQUxfTEFO",
            "VEVSTl9SSVRFX0NPSU5fQhCKARItCihWSVJUVUFMX0lURU1fVklSVFVBTF9M",
            "QU5URVJOX1JJVEVfQ09JTl9DEIsBEioKJVZJUlRVQUxfSVRFTV9WSVJUVUFM",
            "X1JPR1VFX0RJQVJZX0NPSU4QjAESLQooVklSVFVBTF9JVEVNX1ZJUlRVQUxf",
            "U1VNTUVSX1RJTUVfVjJfQ09JThCNARIyCi1WSVJUVUFMX0lURU1fVklSVFVB",
            "TF9ST0dVRV9ESUFSWV9EVU5HRU9OX0NPSU4QjgESMQosVklSVFVBTF9JVEVN",
            "X1ZJUlRVQUxfR1JBVkVOX0lOTk9DRU5DRV9DT0lOX0EQjwESMQosVklSVFVB",
            "TF9JVEVNX1ZJUlRVQUxfR1JBVkVOX0lOTk9DRU5DRV9DT0lOX0IQkAESLgop",
            "VklSVFVBTF9JVEVNX1ZJUlRVQUxfVFJFQVNVUkVfU0VFTElFX0NPSU4QkQES",
            "LAonVklSVFVBTF9JVEVNX1ZJUlRVQUxfVklOVEFHRV9QT1BVTEFSSVRZEJMB",
            "EiEKHFZJUlRVQUxfSVRFTV9WSVJUVUFMX0dDR19FWFAQkgESLwoqVklSVFVB",
            "TF9JVEVNX1ZJUlRVQUxfVklOVEFHRV9NQVJLRVRfQ09JTl9BEJQBEi8KKlZJ",
            "UlRVQUxfSVRFTV9WSVJUVUFMX1ZJTlRBR0VfTUFSS0VUX0NPSU5fQhCVARIv",
            "CipWSVJUVUFMX0lURU1fVklSVFVBTF9WSU5UQUdFX01BUktFVF9DT0lOX0MQ",
            "lgESNQowVklSVFVBTF9JVEVNX1ZJUlRVQUxfRlVOR1VTX0ZJR0hURVJfQ0FQ",
            "VFVSRV9DT0lOEJcBEjYKMVZJUlRVQUxfSVRFTV9WSVJUVUFMX0ZVTkdVU19G",
            "SUdIVEVSX1RSQUlOSU5HX0NPSU4QmAESMgotVklSVFVBTF9JVEVNX1ZJUlRV",
            "QUxfRUZGSUdZX0NIQUxMRU5HRV9WMl9DT0lOEJkBEiwKJ1ZJUlRVQUxfSVRF",
            "TV9WSVJUVUFMX0JSSUNLX0JSRUFLRVJfQ09JThCbARIfChpWSVJUVUFMX0lU",
            "RU1fVklSVFVBTF9IQ09JThDJARIfChpWSVJUVUFMX0lURU1fVklSVFVBTF9T",
            "Q09JThDKARIfChpWSVJUVUFMX0lURU1fVklSVFVBTF9NQ09JThDLARIjCh5W",
            "SVJUVUFMX0lURU1fVklSVFVBTF9IT01FX0NPSU4QzAESIgodVklSVFVBTF9J",
            "VEVNX1ZJUlRVQUxfR0NHX0NPSU4QzQESLAonVklSVFVBTF9JVEVNX1ZJUlRV",
            "QUxfSU5BWlVNQV9SRVBVVEFUSU9OELoCEisKJlZJUlRVQUxfSVRFTV9WSVJU",
            "VUFMX01FTkdERV9SRVBVVEFUSU9OELsCEisKJlZJUlRVQUxfSVRFTV9WSVJU",
            "VUFMX1NVTUVSVV9SRVBVVEFUSU9OELwCEioKJVZJUlRVQUxfSVRFTV9WSVJU",
            "VUFMX0xJWVVFX1JFUFVUQVRJT04QvQJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.VirtualItem), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum VirtualItem {
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_NONE")] VirtualNone = 0,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_AVATAR_EXP")] VirtualAvatarExp = 101,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_PLAYER_EXP")] VirtualPlayerExp = 102,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_FETTER_EXP")] VirtualFetterExp = 105,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_RESIN")] VirtualResin = 106,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_LEGENDARY_KEY")] VirtualLegendaryKey = 107,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_ASTER_PROGRESS")] VirtualAsterProgress = 108,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_ASTER_CREDIT")] VirtualAsterCredit = 109,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_ASTER_TOKEN")] VirtualAsterToken = 110,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_SHIMMERING_ESSENCE")] VirtualShimmeringEssence = 111,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_WARM_ESSENCE")] VirtualWarmEssence = 112,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_WONDROUS_ESSENCE")] VirtualWondrousEssence = 113,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_TREASURE_MAP_TOKEN")] VirtualTreasureMapToken = 114,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_SEA_LAMP_COIN")] VirtualSeaLampCoin = 115,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_SEA_LAMP_POPULARITY")] VirtualSeaLampPopularity = 116,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_MECHANICUS_COIN")] VirtualMechanicusCoin = 117,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_FLEUR_FAIR_CREDIT")] VirtualFleurFairCredit = 118,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_FLEUR_FAIR_TOKEN")] VirtualFleurFairToken = 119,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_WATER_SPIRIT_COIN")] VirtualWaterSpiritCoin = 120,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_HOME_EXP")] VirtualHomeExp = 121,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_CHANNELLER_SLAB_TOKEN")] VirtualChannellerSlabToken = 122,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_HIDE_AND_SEEK_COIN")] VirtualHideAndSeekCoin = 123,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_SUMMER_TIME_DRAFT_WOOD")] VirtualSummerTimeDraftWood = 124,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_SUMMER_TIME_MINI_HARPASTUM")] VirtualSummerTimeMiniHarpastum = 125,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_BOUNCE_CONJURING_COIN")] VirtualBounceConjuringCoin = 126,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_BLITZ_RUSH_COIN_A")] VirtualBlitzRushCoinA = 127,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_BLITZ_RUSH_COIN_B")] VirtualBlitzRushCoinB = 128,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_CHESS_EXP")] VirtualChessExp = 129,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_CHESS_COIN")] VirtualChessCoin = 130,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_LUNA_RITE_ATMOSPHERE")] VirtualLunaRiteAtmosphere = 131,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_ROGUELIKE_COIN_A")] VirtualRoguelikeCoinA = 132,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_ROGUELIKE_COIN_B")] VirtualRoguelikeCoinB = 133,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_ROGUELIKE_COIN_C")] VirtualRoguelikeCoinC = 134,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_WINTER_CAMP_COIN_A")] VirtualWinterCampCoinA = 135,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_WINTER_CAMP_COIN_B")] VirtualWinterCampCoinB = 136,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_LANTERN_RITE_COIN_A")] VirtualLanternRiteCoinA = 137,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_LANTERN_RITE_COIN_B")] VirtualLanternRiteCoinB = 138,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_LANTERN_RITE_COIN_C")] VirtualLanternRiteCoinC = 139,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_ROGUE_DIARY_COIN")] VirtualRogueDiaryCoin = 140,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_SUMMER_TIME_V2_COIN")] VirtualSummerTimeV2Coin = 141,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_ROGUE_DIARY_DUNGEON_COIN")] VirtualRogueDiaryDungeonCoin = 142,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_GRAVEN_INNOCENCE_COIN_A")] VirtualGravenInnocenceCoinA = 143,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_GRAVEN_INNOCENCE_COIN_B")] VirtualGravenInnocenceCoinB = 144,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_TREASURE_SEELIE_COIN")] VirtualTreasureSeelieCoin = 145,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_VINTAGE_POPULARITY")] VirtualVintagePopularity = 147,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_GCG_EXP")] VirtualGcgExp = 146,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_VINTAGE_MARKET_COIN_A")] VirtualVintageMarketCoinA = 148,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_VINTAGE_MARKET_COIN_B")] VirtualVintageMarketCoinB = 149,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_VINTAGE_MARKET_COIN_C")] VirtualVintageMarketCoinC = 150,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_FUNGUS_FIGHTER_CAPTURE_COIN")] VirtualFungusFighterCaptureCoin = 151,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_FUNGUS_FIGHTER_TRAINING_COIN")] VirtualFungusFighterTrainingCoin = 152,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_EFFIGY_CHALLENGE_V2_COIN")] VirtualEffigyChallengeV2Coin = 153,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_BRICK_BREAKER_COIN")] VirtualBrickBreakerCoin = 155,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_HCOIN")] VirtualHcoin = 201,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_SCOIN")] VirtualScoin = 202,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_MCOIN")] VirtualMcoin = 203,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_HOME_COIN")] VirtualHomeCoin = 204,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_GCG_COIN")] VirtualGcgCoin = 205,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_INAZUMA_REPUTATION")] VirtualInazumaReputation = 314,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_MENGDE_REPUTATION")] VirtualMengdeReputation = 315,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_SUMERU_REPUTATION")] VirtualSumeruReputation = 316,
    [pbr::OriginalName("VIRTUAL_ITEM_VIRTUAL_LIYUE_REPUTATION")] VirtualLiyueReputation = 317,
  }

  #endregion

}

#endregion Designer generated code