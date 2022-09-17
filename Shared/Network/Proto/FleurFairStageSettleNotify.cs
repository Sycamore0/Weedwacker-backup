// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairStageSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FleurFairStageSettleNotify.proto</summary>
  public static partial class FleurFairStageSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FleurFairStageSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FleurFairStageSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBGbGV1ckZhaXJTdGFnZVNldHRsZU5vdGlmeS5wcm90bxodRmxldXJGYWly",
            "Qm9zc1NldHRsZUluZm8ucHJvdG8aIEZsZXVyRmFpckdhbGxlcnlTZXR0bGVJ",
            "bmZvLnByb3RvIqwBChpGbGV1ckZhaXJTdGFnZVNldHRsZU5vdGlmeRISCgpz",
            "dGFnZV90eXBlGAogASgNEjoKE2dhbGxlcnlfc2V0dGxlX2luZm8YDSABKAsy",
            "Gy5GbGV1ckZhaXJHYWxsZXJ5U2V0dGxlSW5mb0gAEjQKEGJvc3Nfc2V0dGxl",
            "X2luZm8YDiABKAsyGC5GbGV1ckZhaXJCb3NzU2V0dGxlSW5mb0gAQggKBmRl",
            "dGFpbEIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FleurFairBossSettleInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.FleurFairGallerySettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FleurFairStageSettleNotify), global::Weedwacker.Shared.Network.Proto.FleurFairStageSettleNotify.Parser, new[]{ "StageType", "GallerySettleInfo", "BossSettleInfo" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5356
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class FleurFairStageSettleNotify : pb::IMessage<FleurFairStageSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FleurFairStageSettleNotify> _parser = new pb::MessageParser<FleurFairStageSettleNotify>(() => new FleurFairStageSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FleurFairStageSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FleurFairStageSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairStageSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairStageSettleNotify(FleurFairStageSettleNotify other) : this() {
      stageType_ = other.stageType_;
      switch (other.DetailCase) {
        case DetailOneofCase.GallerySettleInfo:
          GallerySettleInfo = other.GallerySettleInfo.Clone();
          break;
        case DetailOneofCase.BossSettleInfo:
          BossSettleInfo = other.BossSettleInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairStageSettleNotify Clone() {
      return new FleurFairStageSettleNotify(this);
    }

    /// <summary>Field number for the "stage_type" field.</summary>
    public const int StageTypeFieldNumber = 10;
    private uint stageType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageType {
      get { return stageType_; }
      set {
        stageType_ = value;
      }
    }

    /// <summary>Field number for the "gallery_settle_info" field.</summary>
    public const int GallerySettleInfoFieldNumber = 13;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FleurFairGallerySettleInfo GallerySettleInfo {
      get { return detailCase_ == DetailOneofCase.GallerySettleInfo ? (global::Weedwacker.Shared.Network.Proto.FleurFairGallerySettleInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.GallerySettleInfo;
      }
    }

    /// <summary>Field number for the "boss_settle_info" field.</summary>
    public const int BossSettleInfoFieldNumber = 14;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FleurFairBossSettleInfo BossSettleInfo {
      get { return detailCase_ == DetailOneofCase.BossSettleInfo ? (global::Weedwacker.Shared.Network.Proto.FleurFairBossSettleInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.BossSettleInfo;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      GallerySettleInfo = 13,
      BossSettleInfo = 14,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FleurFairStageSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FleurFairStageSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageType != other.StageType) return false;
      if (!object.Equals(GallerySettleInfo, other.GallerySettleInfo)) return false;
      if (!object.Equals(BossSettleInfo, other.BossSettleInfo)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageType != 0) hash ^= StageType.GetHashCode();
      if (detailCase_ == DetailOneofCase.GallerySettleInfo) hash ^= GallerySettleInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.BossSettleInfo) hash ^= BossSettleInfo.GetHashCode();
      hash ^= (int) detailCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (StageType != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StageType);
      }
      if (detailCase_ == DetailOneofCase.GallerySettleInfo) {
        output.WriteRawTag(106);
        output.WriteMessage(GallerySettleInfo);
      }
      if (detailCase_ == DetailOneofCase.BossSettleInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(BossSettleInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StageType != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StageType);
      }
      if (detailCase_ == DetailOneofCase.GallerySettleInfo) {
        output.WriteRawTag(106);
        output.WriteMessage(GallerySettleInfo);
      }
      if (detailCase_ == DetailOneofCase.BossSettleInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(BossSettleInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StageType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageType);
      }
      if (detailCase_ == DetailOneofCase.GallerySettleInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GallerySettleInfo);
      }
      if (detailCase_ == DetailOneofCase.BossSettleInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BossSettleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FleurFairStageSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.StageType != 0) {
        StageType = other.StageType;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.GallerySettleInfo:
          if (GallerySettleInfo == null) {
            GallerySettleInfo = new global::Weedwacker.Shared.Network.Proto.FleurFairGallerySettleInfo();
          }
          GallerySettleInfo.MergeFrom(other.GallerySettleInfo);
          break;
        case DetailOneofCase.BossSettleInfo:
          if (BossSettleInfo == null) {
            BossSettleInfo = new global::Weedwacker.Shared.Network.Proto.FleurFairBossSettleInfo();
          }
          BossSettleInfo.MergeFrom(other.BossSettleInfo);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 80: {
            StageType = input.ReadUInt32();
            break;
          }
          case 106: {
            global::Weedwacker.Shared.Network.Proto.FleurFairGallerySettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairGallerySettleInfo();
            if (detailCase_ == DetailOneofCase.GallerySettleInfo) {
              subBuilder.MergeFrom(GallerySettleInfo);
            }
            input.ReadMessage(subBuilder);
            GallerySettleInfo = subBuilder;
            break;
          }
          case 114: {
            global::Weedwacker.Shared.Network.Proto.FleurFairBossSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairBossSettleInfo();
            if (detailCase_ == DetailOneofCase.BossSettleInfo) {
              subBuilder.MergeFrom(BossSettleInfo);
            }
            input.ReadMessage(subBuilder);
            BossSettleInfo = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 80: {
            StageType = input.ReadUInt32();
            break;
          }
          case 106: {
            global::Weedwacker.Shared.Network.Proto.FleurFairGallerySettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairGallerySettleInfo();
            if (detailCase_ == DetailOneofCase.GallerySettleInfo) {
              subBuilder.MergeFrom(GallerySettleInfo);
            }
            input.ReadMessage(subBuilder);
            GallerySettleInfo = subBuilder;
            break;
          }
          case 114: {
            global::Weedwacker.Shared.Network.Proto.FleurFairBossSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairBossSettleInfo();
            if (detailCase_ == DetailOneofCase.BossSettleInfo) {
              subBuilder.MergeFrom(BossSettleInfo);
            }
            input.ReadMessage(subBuilder);
            BossSettleInfo = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code