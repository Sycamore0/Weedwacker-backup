// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WinterCampAcceptItemResultInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WinterCampAcceptItemResultInfo.proto</summary>
  public static partial class WinterCampAcceptItemResultInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WinterCampAcceptItemResultInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WinterCampAcceptItemResultInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRXaW50ZXJDYW1wQWNjZXB0SXRlbVJlc3VsdEluZm8ucHJvdG8aD0l0ZW1Q",
            "YXJhbS5wcm90byJ7Ch5XaW50ZXJDYW1wQWNjZXB0SXRlbVJlc3VsdEluZm8S",
            "JAoQYWNjZXB0X2l0ZW1fbGlzdBgCIAMoCzIKLkl0ZW1QYXJhbRILCgN1aWQY",
            "BiABKA0SJgoSdW5hY2NlcHRfaXRlbV9saXN0GAkgAygLMgouSXRlbVBhcmFt",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WinterCampAcceptItemResultInfo), global::Weedwacker.Shared.Network.Proto.WinterCampAcceptItemResultInfo.Parser, new[]{ "AcceptItemList", "Uid", "UnacceptItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WinterCampAcceptItemResultInfo : pb::IMessage<WinterCampAcceptItemResultInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WinterCampAcceptItemResultInfo> _parser = new pb::MessageParser<WinterCampAcceptItemResultInfo>(() => new WinterCampAcceptItemResultInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WinterCampAcceptItemResultInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WinterCampAcceptItemResultInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampAcceptItemResultInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampAcceptItemResultInfo(WinterCampAcceptItemResultInfo other) : this() {
      acceptItemList_ = other.acceptItemList_.Clone();
      uid_ = other.uid_;
      unacceptItemList_ = other.unacceptItemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampAcceptItemResultInfo Clone() {
      return new WinterCampAcceptItemResultInfo(this);
    }

    /// <summary>Field number for the "accept_item_list" field.</summary>
    public const int AcceptItemListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_acceptItemList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> acceptItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> AcceptItemList {
      get { return acceptItemList_; }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 6;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "unaccept_item_list" field.</summary>
    public const int UnacceptItemListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_unacceptItemList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> unacceptItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> UnacceptItemList {
      get { return unacceptItemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WinterCampAcceptItemResultInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WinterCampAcceptItemResultInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!acceptItemList_.Equals(other.acceptItemList_)) return false;
      if (Uid != other.Uid) return false;
      if(!unacceptItemList_.Equals(other.unacceptItemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= acceptItemList_.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      hash ^= unacceptItemList_.GetHashCode();
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
      acceptItemList_.WriteTo(output, _repeated_acceptItemList_codec);
      if (Uid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Uid);
      }
      unacceptItemList_.WriteTo(output, _repeated_unacceptItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      acceptItemList_.WriteTo(ref output, _repeated_acceptItemList_codec);
      if (Uid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Uid);
      }
      unacceptItemList_.WriteTo(ref output, _repeated_unacceptItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += acceptItemList_.CalculateSize(_repeated_acceptItemList_codec);
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      size += unacceptItemList_.CalculateSize(_repeated_unacceptItemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WinterCampAcceptItemResultInfo other) {
      if (other == null) {
        return;
      }
      acceptItemList_.Add(other.acceptItemList_);
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      unacceptItemList_.Add(other.unacceptItemList_);
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
            acceptItemList_.AddEntriesFrom(input, _repeated_acceptItemList_codec);
            break;
          }
          case 48: {
            Uid = input.ReadUInt32();
            break;
          }
          case 74: {
            unacceptItemList_.AddEntriesFrom(input, _repeated_unacceptItemList_codec);
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
            acceptItemList_.AddEntriesFrom(ref input, _repeated_acceptItemList_codec);
            break;
          }
          case 48: {
            Uid = input.ReadUInt32();
            break;
          }
          case 74: {
            unacceptItemList_.AddEntriesFrom(ref input, _repeated_unacceptItemList_codec);
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