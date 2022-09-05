// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GachaTransferItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from GachaTransferItem.proto</summary>
  public static partial class GachaTransferItemReflection {

    #region Descriptor
    /// <summary>File descriptor for GachaTransferItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GachaTransferItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHYWNoYVRyYW5zZmVySXRlbS5wcm90bxoPSXRlbVBhcmFtLnByb3RvIksK",
            "EUdhY2hhVHJhbnNmZXJJdGVtEhgKBGl0ZW0YAyABKAsyCi5JdGVtUGFyYW0S",
            "HAoUaXNfdHJhbnNmZXJfaXRlbV9uZXcYASABKAhCGqoCF1dlZWR3YWNrZXIu",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.GachaTransferItem), global::Weedwacker.Server.Proto.GachaTransferItem.Parser, new[]{ "Item", "IsTransferItemNew" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GachaTransferItem : pb::IMessage<GachaTransferItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GachaTransferItem> _parser = new pb::MessageParser<GachaTransferItem>(() => new GachaTransferItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GachaTransferItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.GachaTransferItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaTransferItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaTransferItem(GachaTransferItem other) : this() {
      item_ = other.item_ != null ? other.item_.Clone() : null;
      isTransferItemNew_ = other.isTransferItemNew_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaTransferItem Clone() {
      return new GachaTransferItem(this);
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 3;
    private global::Weedwacker.Server.Proto.ItemParam item_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.ItemParam Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }

    /// <summary>Field number for the "is_transfer_item_new" field.</summary>
    public const int IsTransferItemNewFieldNumber = 1;
    private bool isTransferItemNew_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTransferItemNew {
      get { return isTransferItemNew_; }
      set {
        isTransferItemNew_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GachaTransferItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GachaTransferItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Item, other.Item)) return false;
      if (IsTransferItemNew != other.IsTransferItemNew) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (item_ != null) hash ^= Item.GetHashCode();
      if (IsTransferItemNew != false) hash ^= IsTransferItemNew.GetHashCode();
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
      if (IsTransferItemNew != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsTransferItemNew);
      }
      if (item_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Item);
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
      if (IsTransferItemNew != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsTransferItemNew);
      }
      if (item_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Item);
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
      if (item_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
      }
      if (IsTransferItemNew != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GachaTransferItem other) {
      if (other == null) {
        return;
      }
      if (other.item_ != null) {
        if (item_ == null) {
          Item = new global::Weedwacker.Server.Proto.ItemParam();
        }
        Item.MergeFrom(other.Item);
      }
      if (other.IsTransferItemNew != false) {
        IsTransferItemNew = other.IsTransferItemNew;
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
            IsTransferItemNew = input.ReadBool();
            break;
          }
          case 26: {
            if (item_ == null) {
              Item = new global::Weedwacker.Server.Proto.ItemParam();
            }
            input.ReadMessage(Item);
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
            IsTransferItemNew = input.ReadBool();
            break;
          }
          case 26: {
            if (item_ == null) {
              Item = new global::Weedwacker.Server.Proto.ItemParam();
            }
            input.ReadMessage(Item);
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