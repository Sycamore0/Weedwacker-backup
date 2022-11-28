// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CharAmusementStageData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CharAmusementStageData.proto</summary>
  public static partial class CharAmusementStageDataReflection {

    #region Descriptor
    /// <summary>File descriptor for CharAmusementStageData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CharAmusementStageDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxDaGFyQW11c2VtZW50U3RhZ2VEYXRhLnByb3RvIlAKFkNoYXJBbXVzZW1l",
            "bnRTdGFnZURhdGESEwoLZmluaXNoX3RpbWUYDyABKA0SDwoHaXNfb3BlbhgM",
            "IAEoCBIQCghzdGFnZV9pZBgGIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CharAmusementStageData), global::Weedwacker.Shared.Network.Proto.CharAmusementStageData.Parser, new[]{ "FinishTime", "IsOpen", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CharAmusementStageData : pb::IMessage<CharAmusementStageData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CharAmusementStageData> _parser = new pb::MessageParser<CharAmusementStageData>(() => new CharAmusementStageData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CharAmusementStageData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CharAmusementStageDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CharAmusementStageData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CharAmusementStageData(CharAmusementStageData other) : this() {
      finishTime_ = other.finishTime_;
      isOpen_ = other.isOpen_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CharAmusementStageData Clone() {
      return new CharAmusementStageData(this);
    }

    /// <summary>Field number for the "finish_time" field.</summary>
    public const int FinishTimeFieldNumber = 15;
    private uint finishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishTime {
      get { return finishTime_; }
      set {
        finishTime_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 12;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 6;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CharAmusementStageData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CharAmusementStageData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FinishTime != other.FinishTime) return false;
      if (IsOpen != other.IsOpen) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FinishTime != 0) hash ^= FinishTime.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
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
      if (StageId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StageId);
      }
      if (IsOpen != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsOpen);
      }
      if (FinishTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinishTime);
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
      if (StageId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StageId);
      }
      if (IsOpen != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsOpen);
      }
      if (FinishTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinishTime);
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
      if (FinishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishTime);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CharAmusementStageData other) {
      if (other == null) {
        return;
      }
      if (other.FinishTime != 0) {
        FinishTime = other.FinishTime;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
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
          case 48: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            IsOpen = input.ReadBool();
            break;
          }
          case 120: {
            FinishTime = input.ReadUInt32();
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
          case 48: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            IsOpen = input.ReadBool();
            break;
          }
          case 120: {
            FinishTime = input.ReadUInt32();
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
