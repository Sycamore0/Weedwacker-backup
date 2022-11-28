// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BartenderActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BartenderActivityDetailInfo.proto</summary>
  public static partial class BartenderActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BartenderActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BartenderActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFCYXJ0ZW5kZXJBY3Rpdml0eURldGFpbEluZm8ucHJvdG8aGEJhcnRlbmRl",
            "ckxldmVsSW5mby5wcm90bxoXQmFydGVuZGVyVGFza0luZm8ucHJvdG8i7QEK",
            "G0JhcnRlbmRlckFjdGl2aXR5RGV0YWlsSW5mbxIYChB1bmxvY2tfaXRlbV9s",
            "aXN0GAMgAygNEh4KFmlzX2RldmVsb3BfbW9kdWxlX29wZW4YDSABKAgSGQoR",
            "aXNfY29udGVudF9jbG9zZWQYBiABKAgSLgoRdW5sb2NrX2xldmVsX2xpc3QY",
            "BSADKAsyEy5CYXJ0ZW5kZXJMZXZlbEluZm8SGwoTdW5sb2NrX2Zvcm11bGFf",
            "bGlzdBgOIAMoDRIsChB1bmxvY2tfdGFza19saXN0GAIgAygLMhIuQmFydGVu",
            "ZGVyVGFza0luZm9CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.BartenderLevelInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.BartenderTaskInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BartenderActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.BartenderActivityDetailInfo.Parser, new[]{ "UnlockItemList", "IsDevelopModuleOpen", "IsContentClosed", "UnlockLevelList", "UnlockFormulaList", "UnlockTaskList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BartenderActivityDetailInfo : pb::IMessage<BartenderActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BartenderActivityDetailInfo> _parser = new pb::MessageParser<BartenderActivityDetailInfo>(() => new BartenderActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BartenderActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BartenderActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BartenderActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BartenderActivityDetailInfo(BartenderActivityDetailInfo other) : this() {
      unlockItemList_ = other.unlockItemList_.Clone();
      isDevelopModuleOpen_ = other.isDevelopModuleOpen_;
      isContentClosed_ = other.isContentClosed_;
      unlockLevelList_ = other.unlockLevelList_.Clone();
      unlockFormulaList_ = other.unlockFormulaList_.Clone();
      unlockTaskList_ = other.unlockTaskList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BartenderActivityDetailInfo Clone() {
      return new BartenderActivityDetailInfo(this);
    }

    /// <summary>Field number for the "unlock_item_list" field.</summary>
    public const int UnlockItemListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_unlockItemList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> unlockItemList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockItemList {
      get { return unlockItemList_; }
    }

    /// <summary>Field number for the "is_develop_module_open" field.</summary>
    public const int IsDevelopModuleOpenFieldNumber = 13;
    private bool isDevelopModuleOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDevelopModuleOpen {
      get { return isDevelopModuleOpen_; }
      set {
        isDevelopModuleOpen_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 6;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "unlock_level_list" field.</summary>
    public const int UnlockLevelListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.BartenderLevelInfo> _repeated_unlockLevelList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.BartenderLevelInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.BartenderLevelInfo> unlockLevelList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.BartenderLevelInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.BartenderLevelInfo> UnlockLevelList {
      get { return unlockLevelList_; }
    }

    /// <summary>Field number for the "unlock_formula_list" field.</summary>
    public const int UnlockFormulaListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_unlockFormulaList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> unlockFormulaList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockFormulaList {
      get { return unlockFormulaList_; }
    }

    /// <summary>Field number for the "unlock_task_list" field.</summary>
    public const int UnlockTaskListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.BartenderTaskInfo> _repeated_unlockTaskList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.BartenderTaskInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.BartenderTaskInfo> unlockTaskList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.BartenderTaskInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.BartenderTaskInfo> UnlockTaskList {
      get { return unlockTaskList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BartenderActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BartenderActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unlockItemList_.Equals(other.unlockItemList_)) return false;
      if (IsDevelopModuleOpen != other.IsDevelopModuleOpen) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if(!unlockLevelList_.Equals(other.unlockLevelList_)) return false;
      if(!unlockFormulaList_.Equals(other.unlockFormulaList_)) return false;
      if(!unlockTaskList_.Equals(other.unlockTaskList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unlockItemList_.GetHashCode();
      if (IsDevelopModuleOpen != false) hash ^= IsDevelopModuleOpen.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      hash ^= unlockLevelList_.GetHashCode();
      hash ^= unlockFormulaList_.GetHashCode();
      hash ^= unlockTaskList_.GetHashCode();
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
      unlockTaskList_.WriteTo(output, _repeated_unlockTaskList_codec);
      unlockItemList_.WriteTo(output, _repeated_unlockItemList_codec);
      unlockLevelList_.WriteTo(output, _repeated_unlockLevelList_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsContentClosed);
      }
      if (IsDevelopModuleOpen != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsDevelopModuleOpen);
      }
      unlockFormulaList_.WriteTo(output, _repeated_unlockFormulaList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unlockTaskList_.WriteTo(ref output, _repeated_unlockTaskList_codec);
      unlockItemList_.WriteTo(ref output, _repeated_unlockItemList_codec);
      unlockLevelList_.WriteTo(ref output, _repeated_unlockLevelList_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsContentClosed);
      }
      if (IsDevelopModuleOpen != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsDevelopModuleOpen);
      }
      unlockFormulaList_.WriteTo(ref output, _repeated_unlockFormulaList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unlockItemList_.CalculateSize(_repeated_unlockItemList_codec);
      if (IsDevelopModuleOpen != false) {
        size += 1 + 1;
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      size += unlockLevelList_.CalculateSize(_repeated_unlockLevelList_codec);
      size += unlockFormulaList_.CalculateSize(_repeated_unlockFormulaList_codec);
      size += unlockTaskList_.CalculateSize(_repeated_unlockTaskList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BartenderActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      unlockItemList_.Add(other.unlockItemList_);
      if (other.IsDevelopModuleOpen != false) {
        IsDevelopModuleOpen = other.IsDevelopModuleOpen;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      unlockLevelList_.Add(other.unlockLevelList_);
      unlockFormulaList_.Add(other.unlockFormulaList_);
      unlockTaskList_.Add(other.unlockTaskList_);
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
            unlockTaskList_.AddEntriesFrom(input, _repeated_unlockTaskList_codec);
            break;
          }
          case 26:
          case 24: {
            unlockItemList_.AddEntriesFrom(input, _repeated_unlockItemList_codec);
            break;
          }
          case 42: {
            unlockLevelList_.AddEntriesFrom(input, _repeated_unlockLevelList_codec);
            break;
          }
          case 48: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 104: {
            IsDevelopModuleOpen = input.ReadBool();
            break;
          }
          case 114:
          case 112: {
            unlockFormulaList_.AddEntriesFrom(input, _repeated_unlockFormulaList_codec);
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
            unlockTaskList_.AddEntriesFrom(ref input, _repeated_unlockTaskList_codec);
            break;
          }
          case 26:
          case 24: {
            unlockItemList_.AddEntriesFrom(ref input, _repeated_unlockItemList_codec);
            break;
          }
          case 42: {
            unlockLevelList_.AddEntriesFrom(ref input, _repeated_unlockLevelList_codec);
            break;
          }
          case 48: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 104: {
            IsDevelopModuleOpen = input.ReadBool();
            break;
          }
          case 114:
          case 112: {
            unlockFormulaList_.AddEntriesFrom(ref input, _repeated_unlockFormulaList_codec);
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
