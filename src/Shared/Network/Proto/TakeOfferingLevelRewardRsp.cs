// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeOfferingLevelRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TakeOfferingLevelRewardRsp.proto</summary>
  public static partial class TakeOfferingLevelRewardRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeOfferingLevelRewardRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeOfferingLevelRewardRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBUYWtlT2ZmZXJpbmdMZXZlbFJld2FyZFJzcC5wcm90bxoPSXRlbVBhcmFt",
            "LnByb3RvInUKGlRha2VPZmZlcmluZ0xldmVsUmV3YXJkUnNwEhMKC29mZmVy",
            "aW5nX2lkGAMgASgNEhIKCnRha2VfbGV2ZWwYBCABKA0SDwoHcmV0Y29kZRgI",
            "IAEoBRIdCglpdGVtX2xpc3QYAiADKAsyCi5JdGVtUGFyYW1CIqoCH1dlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TakeOfferingLevelRewardRsp), global::Weedwacker.Shared.Network.Proto.TakeOfferingLevelRewardRsp.Parser, new[]{ "OfferingId", "TakeLevel", "Retcode", "ItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2911
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class TakeOfferingLevelRewardRsp : pb::IMessage<TakeOfferingLevelRewardRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeOfferingLevelRewardRsp> _parser = new pb::MessageParser<TakeOfferingLevelRewardRsp>(() => new TakeOfferingLevelRewardRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeOfferingLevelRewardRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TakeOfferingLevelRewardRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeOfferingLevelRewardRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeOfferingLevelRewardRsp(TakeOfferingLevelRewardRsp other) : this() {
      offeringId_ = other.offeringId_;
      takeLevel_ = other.takeLevel_;
      retcode_ = other.retcode_;
      itemList_ = other.itemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeOfferingLevelRewardRsp Clone() {
      return new TakeOfferingLevelRewardRsp(this);
    }

    /// <summary>Field number for the "offering_id" field.</summary>
    public const int OfferingIdFieldNumber = 3;
    private uint offeringId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OfferingId {
      get { return offeringId_; }
      set {
        offeringId_ = value;
      }
    }

    /// <summary>Field number for the "take_level" field.</summary>
    public const int TakeLevelFieldNumber = 4;
    private uint takeLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TakeLevel {
      get { return takeLevel_; }
      set {
        takeLevel_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> itemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> ItemList {
      get { return itemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeOfferingLevelRewardRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeOfferingLevelRewardRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OfferingId != other.OfferingId) return false;
      if (TakeLevel != other.TakeLevel) return false;
      if (Retcode != other.Retcode) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OfferingId != 0) hash ^= OfferingId.GetHashCode();
      if (TakeLevel != 0) hash ^= TakeLevel.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= itemList_.GetHashCode();
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
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (OfferingId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OfferingId);
      }
      if (TakeLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TakeLevel);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
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
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (OfferingId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OfferingId);
      }
      if (TakeLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TakeLevel);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
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
      if (TakeLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TakeLevel);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeOfferingLevelRewardRsp other) {
      if (other == null) {
        return;
      }
      if (other.OfferingId != 0) {
        OfferingId = other.OfferingId;
      }
      if (other.TakeLevel != 0) {
        TakeLevel = other.TakeLevel;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      itemList_.Add(other.itemList_);
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
          case 18: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 24: {
            OfferingId = input.ReadUInt32();
            break;
          }
          case 32: {
            TakeLevel = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
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
          case 18: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 24: {
            OfferingId = input.ReadUInt32();
            break;
          }
          case 32: {
            TakeLevel = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
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