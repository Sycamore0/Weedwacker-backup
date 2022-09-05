// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerOfferingData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from PlayerOfferingData.proto</summary>
  public static partial class PlayerOfferingDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerOfferingData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerOfferingDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQbGF5ZXJPZmZlcmluZ0RhdGEucHJvdG8ijgEKElBsYXllck9mZmVyaW5n",
            "RGF0YRITCgtvZmZlcmluZ19pZBgBIAEoDRIZChFpc19maXJzdF9pbnRlcmFj",
            "dBgPIAEoCBINCgVsZXZlbBgMIAEoDRIfChd0YWtlbl9sZXZlbF9yZXdhcmRf",
            "bGlzdBgIIAMoDRIYChBpc19uZXdfbWF4X2xldmVsGAYgASgIQhqqAhdXZWVk",
            "d2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.PlayerOfferingData), global::Weedwacker.Server.Proto.PlayerOfferingData.Parser, new[]{ "OfferingId", "IsFirstInteract", "Level", "TakenLevelRewardList", "IsNewMaxLevel" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerOfferingData : pb::IMessage<PlayerOfferingData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerOfferingData> _parser = new pb::MessageParser<PlayerOfferingData>(() => new PlayerOfferingData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerOfferingData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.PlayerOfferingDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerOfferingData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerOfferingData(PlayerOfferingData other) : this() {
      offeringId_ = other.offeringId_;
      isFirstInteract_ = other.isFirstInteract_;
      level_ = other.level_;
      takenLevelRewardList_ = other.takenLevelRewardList_.Clone();
      isNewMaxLevel_ = other.isNewMaxLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerOfferingData Clone() {
      return new PlayerOfferingData(this);
    }

    /// <summary>Field number for the "offering_id" field.</summary>
    public const int OfferingIdFieldNumber = 1;
    private uint offeringId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OfferingId {
      get { return offeringId_; }
      set {
        offeringId_ = value;
      }
    }

    /// <summary>Field number for the "is_first_interact" field.</summary>
    public const int IsFirstInteractFieldNumber = 15;
    private bool isFirstInteract_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstInteract {
      get { return isFirstInteract_; }
      set {
        isFirstInteract_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 12;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "taken_level_reward_list" field.</summary>
    public const int TakenLevelRewardListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_takenLevelRewardList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> takenLevelRewardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TakenLevelRewardList {
      get { return takenLevelRewardList_; }
    }

    /// <summary>Field number for the "is_new_max_level" field.</summary>
    public const int IsNewMaxLevelFieldNumber = 6;
    private bool isNewMaxLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewMaxLevel {
      get { return isNewMaxLevel_; }
      set {
        isNewMaxLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerOfferingData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerOfferingData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OfferingId != other.OfferingId) return false;
      if (IsFirstInteract != other.IsFirstInteract) return false;
      if (Level != other.Level) return false;
      if(!takenLevelRewardList_.Equals(other.takenLevelRewardList_)) return false;
      if (IsNewMaxLevel != other.IsNewMaxLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OfferingId != 0) hash ^= OfferingId.GetHashCode();
      if (IsFirstInteract != false) hash ^= IsFirstInteract.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= takenLevelRewardList_.GetHashCode();
      if (IsNewMaxLevel != false) hash ^= IsNewMaxLevel.GetHashCode();
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
      if (OfferingId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OfferingId);
      }
      if (IsNewMaxLevel != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsNewMaxLevel);
      }
      takenLevelRewardList_.WriteTo(output, _repeated_takenLevelRewardList_codec);
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
      }
      if (IsFirstInteract != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsFirstInteract);
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
      if (OfferingId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OfferingId);
      }
      if (IsNewMaxLevel != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsNewMaxLevel);
      }
      takenLevelRewardList_.WriteTo(ref output, _repeated_takenLevelRewardList_codec);
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
      }
      if (IsFirstInteract != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsFirstInteract);
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
      if (OfferingId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OfferingId);
      }
      if (IsFirstInteract != false) {
        size += 1 + 1;
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      size += takenLevelRewardList_.CalculateSize(_repeated_takenLevelRewardList_codec);
      if (IsNewMaxLevel != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerOfferingData other) {
      if (other == null) {
        return;
      }
      if (other.OfferingId != 0) {
        OfferingId = other.OfferingId;
      }
      if (other.IsFirstInteract != false) {
        IsFirstInteract = other.IsFirstInteract;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      takenLevelRewardList_.Add(other.takenLevelRewardList_);
      if (other.IsNewMaxLevel != false) {
        IsNewMaxLevel = other.IsNewMaxLevel;
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
          case 8: {
            OfferingId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsNewMaxLevel = input.ReadBool();
            break;
          }
          case 66:
          case 64: {
            takenLevelRewardList_.AddEntriesFrom(input, _repeated_takenLevelRewardList_codec);
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
            break;
          }
          case 120: {
            IsFirstInteract = input.ReadBool();
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
          case 8: {
            OfferingId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsNewMaxLevel = input.ReadBool();
            break;
          }
          case 66:
          case 64: {
            takenLevelRewardList_.AddEntriesFrom(ref input, _repeated_takenLevelRewardList_codec);
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
            break;
          }
          case 120: {
            IsFirstInteract = input.ReadBool();
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