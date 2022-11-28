// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageHuntingSecondStageSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VintageHuntingSecondStageSettleInfo.proto</summary>
  public static partial class VintageHuntingSecondStageSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageHuntingSecondStageSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageHuntingSecondStageSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilWaW50YWdlSHVudGluZ1NlY29uZFN0YWdlU2V0dGxlSW5mby5wcm90byLf",
            "AQojVmludGFnZUh1bnRpbmdTZWNvbmRTdGFnZVNldHRsZUluZm8SUgoQYW5p",
            "bWFsX2NvdW50X21hcBgGIAMoCzI4LlZpbnRhZ2VIdW50aW5nU2Vjb25kU3Rh",
            "Z2VTZXR0bGVJbmZvLkFuaW1hbENvdW50TWFwRW50cnkSGgoSY2FwdHVyZV9h",
            "bmltYWxfbnVtGAcgASgNEhEKCXRvdGFsX251bRgPIAEoDRo1ChNBbmltYWxD",
            "b3VudE1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFC",
            "IqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfo), global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfo.Parser, new[]{ "AnimalCountMap", "CaptureAnimalNum", "TotalNum" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageHuntingSecondStageSettleInfo : pb::IMessage<VintageHuntingSecondStageSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageHuntingSecondStageSettleInfo> _parser = new pb::MessageParser<VintageHuntingSecondStageSettleInfo>(() => new VintageHuntingSecondStageSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageHuntingSecondStageSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingSecondStageSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingSecondStageSettleInfo(VintageHuntingSecondStageSettleInfo other) : this() {
      animalCountMap_ = other.animalCountMap_.Clone();
      captureAnimalNum_ = other.captureAnimalNum_;
      totalNum_ = other.totalNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingSecondStageSettleInfo Clone() {
      return new VintageHuntingSecondStageSettleInfo(this);
    }

    /// <summary>Field number for the "animal_count_map" field.</summary>
    public const int AnimalCountMapFieldNumber = 6;
    private static readonly pbc::MapField<uint, uint>.Codec _map_animalCountMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 50);
    private readonly pbc::MapField<uint, uint> animalCountMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> AnimalCountMap {
      get { return animalCountMap_; }
    }

    /// <summary>Field number for the "capture_animal_num" field.</summary>
    public const int CaptureAnimalNumFieldNumber = 7;
    private uint captureAnimalNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CaptureAnimalNum {
      get { return captureAnimalNum_; }
      set {
        captureAnimalNum_ = value;
      }
    }

    /// <summary>Field number for the "total_num" field.</summary>
    public const int TotalNumFieldNumber = 15;
    private uint totalNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalNum {
      get { return totalNum_; }
      set {
        totalNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageHuntingSecondStageSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageHuntingSecondStageSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!AnimalCountMap.Equals(other.AnimalCountMap)) return false;
      if (CaptureAnimalNum != other.CaptureAnimalNum) return false;
      if (TotalNum != other.TotalNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= AnimalCountMap.GetHashCode();
      if (CaptureAnimalNum != 0) hash ^= CaptureAnimalNum.GetHashCode();
      if (TotalNum != 0) hash ^= TotalNum.GetHashCode();
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
      animalCountMap_.WriteTo(output, _map_animalCountMap_codec);
      if (CaptureAnimalNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CaptureAnimalNum);
      }
      if (TotalNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TotalNum);
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
      animalCountMap_.WriteTo(ref output, _map_animalCountMap_codec);
      if (CaptureAnimalNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CaptureAnimalNum);
      }
      if (TotalNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TotalNum);
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
      size += animalCountMap_.CalculateSize(_map_animalCountMap_codec);
      if (CaptureAnimalNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CaptureAnimalNum);
      }
      if (TotalNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageHuntingSecondStageSettleInfo other) {
      if (other == null) {
        return;
      }
      animalCountMap_.Add(other.animalCountMap_);
      if (other.CaptureAnimalNum != 0) {
        CaptureAnimalNum = other.CaptureAnimalNum;
      }
      if (other.TotalNum != 0) {
        TotalNum = other.TotalNum;
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
          case 50: {
            animalCountMap_.AddEntriesFrom(input, _map_animalCountMap_codec);
            break;
          }
          case 56: {
            CaptureAnimalNum = input.ReadUInt32();
            break;
          }
          case 120: {
            TotalNum = input.ReadUInt32();
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
          case 50: {
            animalCountMap_.AddEntriesFrom(ref input, _map_animalCountMap_codec);
            break;
          }
          case 56: {
            CaptureAnimalNum = input.ReadUInt32();
            break;
          }
          case 120: {
            TotalNum = input.ReadUInt32();
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
