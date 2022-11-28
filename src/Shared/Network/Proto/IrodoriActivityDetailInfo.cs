// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from IrodoriActivityDetailInfo.proto</summary>
  public static partial class IrodoriActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for IrodoriActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IrodoriActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Jcm9kb3JpQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvGhZJcm9kb3JpQ2hl",
            "c3NEYXRhLnByb3RvGhdJcm9kb3JpRmxvd2VyRGF0YS5wcm90bxocSXJvZG9y",
            "aU1hc3RlckxldmVsSW5mby5wcm90bxoXSXJvZG9yaVBvZXRyeURhdGEucHJv",
            "dG8iyAEKGUlyb2RvcmlBY3Rpdml0eURldGFpbEluZm8SMgoRbWFzdGVyX2xl",
            "dmVsX2xpc3QYCyADKAsyFy5Jcm9kb3JpTWFzdGVyTGV2ZWxJbmZvEicKC2Zs",
            "b3dlcl9kYXRhGAYgASgLMhIuSXJvZG9yaUZsb3dlckRhdGESJwoLcG9ldHJ5",
            "X2RhdGEYCCABKAsyEi5Jcm9kb3JpUG9ldHJ5RGF0YRIlCgpjaGVzc19kYXRh",
            "GA4gASgLMhEuSXJvZG9yaUNoZXNzRGF0YUIiqgIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.IrodoriChessDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.IrodoriFlowerDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.IrodoriMasterLevelInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.IrodoriPoetryDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.IrodoriActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.IrodoriActivityDetailInfo.Parser, new[]{ "MasterLevelList", "FlowerData", "PoetryData", "ChessData" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IrodoriActivityDetailInfo : pb::IMessage<IrodoriActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IrodoriActivityDetailInfo> _parser = new pb::MessageParser<IrodoriActivityDetailInfo>(() => new IrodoriActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IrodoriActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.IrodoriActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriActivityDetailInfo(IrodoriActivityDetailInfo other) : this() {
      masterLevelList_ = other.masterLevelList_.Clone();
      flowerData_ = other.flowerData_ != null ? other.flowerData_.Clone() : null;
      poetryData_ = other.poetryData_ != null ? other.poetryData_.Clone() : null;
      chessData_ = other.chessData_ != null ? other.chessData_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriActivityDetailInfo Clone() {
      return new IrodoriActivityDetailInfo(this);
    }

    /// <summary>Field number for the "master_level_list" field.</summary>
    public const int MasterLevelListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.IrodoriMasterLevelInfo> _repeated_masterLevelList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.IrodoriMasterLevelInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.IrodoriMasterLevelInfo> masterLevelList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.IrodoriMasterLevelInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.IrodoriMasterLevelInfo> MasterLevelList {
      get { return masterLevelList_; }
    }

    /// <summary>Field number for the "flower_data" field.</summary>
    public const int FlowerDataFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.IrodoriFlowerData flowerData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.IrodoriFlowerData FlowerData {
      get { return flowerData_; }
      set {
        flowerData_ = value;
      }
    }

    /// <summary>Field number for the "poetry_data" field.</summary>
    public const int PoetryDataFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.IrodoriPoetryData poetryData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.IrodoriPoetryData PoetryData {
      get { return poetryData_; }
      set {
        poetryData_ = value;
      }
    }

    /// <summary>Field number for the "chess_data" field.</summary>
    public const int ChessDataFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.IrodoriChessData chessData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.IrodoriChessData ChessData {
      get { return chessData_; }
      set {
        chessData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IrodoriActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IrodoriActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!masterLevelList_.Equals(other.masterLevelList_)) return false;
      if (!object.Equals(FlowerData, other.FlowerData)) return false;
      if (!object.Equals(PoetryData, other.PoetryData)) return false;
      if (!object.Equals(ChessData, other.ChessData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= masterLevelList_.GetHashCode();
      if (flowerData_ != null) hash ^= FlowerData.GetHashCode();
      if (poetryData_ != null) hash ^= PoetryData.GetHashCode();
      if (chessData_ != null) hash ^= ChessData.GetHashCode();
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
      if (flowerData_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(FlowerData);
      }
      if (poetryData_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PoetryData);
      }
      masterLevelList_.WriteTo(output, _repeated_masterLevelList_codec);
      if (chessData_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(ChessData);
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
      if (flowerData_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(FlowerData);
      }
      if (poetryData_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PoetryData);
      }
      masterLevelList_.WriteTo(ref output, _repeated_masterLevelList_codec);
      if (chessData_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(ChessData);
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
      size += masterLevelList_.CalculateSize(_repeated_masterLevelList_codec);
      if (flowerData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FlowerData);
      }
      if (poetryData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PoetryData);
      }
      if (chessData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChessData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IrodoriActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      masterLevelList_.Add(other.masterLevelList_);
      if (other.flowerData_ != null) {
        if (flowerData_ == null) {
          FlowerData = new global::Weedwacker.Shared.Network.Proto.IrodoriFlowerData();
        }
        FlowerData.MergeFrom(other.FlowerData);
      }
      if (other.poetryData_ != null) {
        if (poetryData_ == null) {
          PoetryData = new global::Weedwacker.Shared.Network.Proto.IrodoriPoetryData();
        }
        PoetryData.MergeFrom(other.PoetryData);
      }
      if (other.chessData_ != null) {
        if (chessData_ == null) {
          ChessData = new global::Weedwacker.Shared.Network.Proto.IrodoriChessData();
        }
        ChessData.MergeFrom(other.ChessData);
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
            if (flowerData_ == null) {
              FlowerData = new global::Weedwacker.Shared.Network.Proto.IrodoriFlowerData();
            }
            input.ReadMessage(FlowerData);
            break;
          }
          case 66: {
            if (poetryData_ == null) {
              PoetryData = new global::Weedwacker.Shared.Network.Proto.IrodoriPoetryData();
            }
            input.ReadMessage(PoetryData);
            break;
          }
          case 90: {
            masterLevelList_.AddEntriesFrom(input, _repeated_masterLevelList_codec);
            break;
          }
          case 114: {
            if (chessData_ == null) {
              ChessData = new global::Weedwacker.Shared.Network.Proto.IrodoriChessData();
            }
            input.ReadMessage(ChessData);
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
            if (flowerData_ == null) {
              FlowerData = new global::Weedwacker.Shared.Network.Proto.IrodoriFlowerData();
            }
            input.ReadMessage(FlowerData);
            break;
          }
          case 66: {
            if (poetryData_ == null) {
              PoetryData = new global::Weedwacker.Shared.Network.Proto.IrodoriPoetryData();
            }
            input.ReadMessage(PoetryData);
            break;
          }
          case 90: {
            masterLevelList_.AddEntriesFrom(ref input, _repeated_masterLevelList_codec);
            break;
          }
          case 114: {
            if (chessData_ == null) {
              ChessData = new global::Weedwacker.Shared.Network.Proto.IrodoriChessData();
            }
            input.ReadMessage(ChessData);
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
