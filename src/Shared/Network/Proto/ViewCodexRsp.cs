// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ViewCodexRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ViewCodexRsp.proto</summary>
  public static partial class ViewCodexRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ViewCodexRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ViewCodexRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJWaWV3Q29kZXhSc3AucHJvdG8aE0NvZGV4VHlwZURhdGEucHJvdG8ingEK",
            "DFZpZXdDb2RleFJzcBIPCgdyZXRjb2RlGAwgASgFEhsKE1VuazI4MDBfSVBP",
            "Q0pJUEdORUoYCiADKA0SGwoTVW5rMjcwMF9ERkpKSEZISElIRhgDIAMoDRIm",
            "Cg50eXBlX2RhdGFfbGlzdBgJIAMoCzIOLkNvZGV4VHlwZURhdGESGwoTVW5r",
            "MjgwMF9PSVBKQ0VQR0pDRhgPIAMoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CodexTypeDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ViewCodexRsp), global::Weedwacker.Shared.Network.Proto.ViewCodexRsp.Parser, new[]{ "Retcode", "Unk2800IPOCJIPGNEJ", "Unk2700DFJJHFHHIHF", "TypeDataList", "Unk2800OIPJCEPGJCF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4201
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ViewCodexRsp : pb::IMessage<ViewCodexRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ViewCodexRsp> _parser = new pb::MessageParser<ViewCodexRsp>(() => new ViewCodexRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ViewCodexRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ViewCodexRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ViewCodexRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ViewCodexRsp(ViewCodexRsp other) : this() {
      retcode_ = other.retcode_;
      unk2800IPOCJIPGNEJ_ = other.unk2800IPOCJIPGNEJ_.Clone();
      unk2700DFJJHFHHIHF_ = other.unk2700DFJJHFHHIHF_.Clone();
      typeDataList_ = other.typeDataList_.Clone();
      unk2800OIPJCEPGJCF_ = other.unk2800OIPJCEPGJCF_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ViewCodexRsp Clone() {
      return new ViewCodexRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "Unk2800_IPOCJIPGNEJ" field.</summary>
    public const int Unk2800IPOCJIPGNEJFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_unk2800IPOCJIPGNEJ_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> unk2800IPOCJIPGNEJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2800IPOCJIPGNEJ {
      get { return unk2800IPOCJIPGNEJ_; }
    }

    /// <summary>Field number for the "Unk2700_DFJJHFHHIHF" field.</summary>
    public const int Unk2700DFJJHFHHIHFFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700DFJJHFHHIHF_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> unk2700DFJJHFHHIHF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700DFJJHFHHIHF {
      get { return unk2700DFJJHFHHIHF_; }
    }

    /// <summary>Field number for the "type_data_list" field.</summary>
    public const int TypeDataListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CodexTypeData> _repeated_typeDataList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.CodexTypeData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CodexTypeData> typeDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CodexTypeData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CodexTypeData> TypeDataList {
      get { return typeDataList_; }
    }

    /// <summary>Field number for the "Unk2800_OIPJCEPGJCF" field.</summary>
    public const int Unk2800OIPJCEPGJCFFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_unk2800OIPJCEPGJCF_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> unk2800OIPJCEPGJCF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2800OIPJCEPGJCF {
      get { return unk2800OIPJCEPGJCF_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ViewCodexRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ViewCodexRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!unk2800IPOCJIPGNEJ_.Equals(other.unk2800IPOCJIPGNEJ_)) return false;
      if(!unk2700DFJJHFHHIHF_.Equals(other.unk2700DFJJHFHHIHF_)) return false;
      if(!typeDataList_.Equals(other.typeDataList_)) return false;
      if(!unk2800OIPJCEPGJCF_.Equals(other.unk2800OIPJCEPGJCF_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= unk2800IPOCJIPGNEJ_.GetHashCode();
      hash ^= unk2700DFJJHFHHIHF_.GetHashCode();
      hash ^= typeDataList_.GetHashCode();
      hash ^= unk2800OIPJCEPGJCF_.GetHashCode();
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
      unk2700DFJJHFHHIHF_.WriteTo(output, _repeated_unk2700DFJJHFHHIHF_codec);
      typeDataList_.WriteTo(output, _repeated_typeDataList_codec);
      unk2800IPOCJIPGNEJ_.WriteTo(output, _repeated_unk2800IPOCJIPGNEJ_codec);
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      unk2800OIPJCEPGJCF_.WriteTo(output, _repeated_unk2800OIPJCEPGJCF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk2700DFJJHFHHIHF_.WriteTo(ref output, _repeated_unk2700DFJJHFHHIHF_codec);
      typeDataList_.WriteTo(ref output, _repeated_typeDataList_codec);
      unk2800IPOCJIPGNEJ_.WriteTo(ref output, _repeated_unk2800IPOCJIPGNEJ_codec);
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      unk2800OIPJCEPGJCF_.WriteTo(ref output, _repeated_unk2800OIPJCEPGJCF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += unk2800IPOCJIPGNEJ_.CalculateSize(_repeated_unk2800IPOCJIPGNEJ_codec);
      size += unk2700DFJJHFHHIHF_.CalculateSize(_repeated_unk2700DFJJHFHHIHF_codec);
      size += typeDataList_.CalculateSize(_repeated_typeDataList_codec);
      size += unk2800OIPJCEPGJCF_.CalculateSize(_repeated_unk2800OIPJCEPGJCF_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ViewCodexRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      unk2800IPOCJIPGNEJ_.Add(other.unk2800IPOCJIPGNEJ_);
      unk2700DFJJHFHHIHF_.Add(other.unk2700DFJJHFHHIHF_);
      typeDataList_.Add(other.typeDataList_);
      unk2800OIPJCEPGJCF_.Add(other.unk2800OIPJCEPGJCF_);
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
          case 26:
          case 24: {
            unk2700DFJJHFHHIHF_.AddEntriesFrom(input, _repeated_unk2700DFJJHFHHIHF_codec);
            break;
          }
          case 74: {
            typeDataList_.AddEntriesFrom(input, _repeated_typeDataList_codec);
            break;
          }
          case 82:
          case 80: {
            unk2800IPOCJIPGNEJ_.AddEntriesFrom(input, _repeated_unk2800IPOCJIPGNEJ_codec);
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122:
          case 120: {
            unk2800OIPJCEPGJCF_.AddEntriesFrom(input, _repeated_unk2800OIPJCEPGJCF_codec);
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
          case 26:
          case 24: {
            unk2700DFJJHFHHIHF_.AddEntriesFrom(ref input, _repeated_unk2700DFJJHFHHIHF_codec);
            break;
          }
          case 74: {
            typeDataList_.AddEntriesFrom(ref input, _repeated_typeDataList_codec);
            break;
          }
          case 82:
          case 80: {
            unk2800IPOCJIPGNEJ_.AddEntriesFrom(ref input, _repeated_unk2800IPOCJIPGNEJ_codec);
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122:
          case 120: {
            unk2800OIPJCEPGJCF_.AddEntriesFrom(ref input, _repeated_unk2800OIPJCEPGJCF_codec);
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