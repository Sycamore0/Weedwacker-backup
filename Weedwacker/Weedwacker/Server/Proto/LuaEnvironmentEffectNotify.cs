// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LuaEnvironmentEffectNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from LuaEnvironmentEffectNotify.proto</summary>
  public static partial class LuaEnvironmentEffectNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for LuaEnvironmentEffectNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LuaEnvironmentEffectNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBMdWFFbnZpcm9ubWVudEVmZmVjdE5vdGlmeS5wcm90byJyChpMdWFFbnZp",
            "cm9ubWVudEVmZmVjdE5vdGlmeRIMCgR0eXBlGAEgASgNEhYKDmludF9wYXJh",
            "bV9saXN0GAwgAygFEhQKDGVmZmVjdF9hbGlhcxgDIAEoCRIYChBmbG9hdF9w",
            "YXJhbV9saXN0GA4gAygCQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.LuaEnvironmentEffectNotify), global::Weedwacker.Server.Proto.LuaEnvironmentEffectNotify.Parser, new[]{ "Type", "IntParamList", "EffectAlias", "FloatParamList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 3408
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class LuaEnvironmentEffectNotify : pb::IMessage<LuaEnvironmentEffectNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LuaEnvironmentEffectNotify> _parser = new pb::MessageParser<LuaEnvironmentEffectNotify>(() => new LuaEnvironmentEffectNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LuaEnvironmentEffectNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.LuaEnvironmentEffectNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuaEnvironmentEffectNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuaEnvironmentEffectNotify(LuaEnvironmentEffectNotify other) : this() {
      type_ = other.type_;
      intParamList_ = other.intParamList_.Clone();
      effectAlias_ = other.effectAlias_;
      floatParamList_ = other.floatParamList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuaEnvironmentEffectNotify Clone() {
      return new LuaEnvironmentEffectNotify(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private uint type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "int_param_list" field.</summary>
    public const int IntParamListFieldNumber = 12;
    private static readonly pb::FieldCodec<int> _repeated_intParamList_codec
        = pb::FieldCodec.ForInt32(98);
    private readonly pbc::RepeatedField<int> intParamList_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> IntParamList {
      get { return intParamList_; }
    }

    /// <summary>Field number for the "effect_alias" field.</summary>
    public const int EffectAliasFieldNumber = 3;
    private string effectAlias_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EffectAlias {
      get { return effectAlias_; }
      set {
        effectAlias_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "float_param_list" field.</summary>
    public const int FloatParamListFieldNumber = 14;
    private static readonly pb::FieldCodec<float> _repeated_floatParamList_codec
        = pb::FieldCodec.ForFloat(114);
    private readonly pbc::RepeatedField<float> floatParamList_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<float> FloatParamList {
      get { return floatParamList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LuaEnvironmentEffectNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LuaEnvironmentEffectNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if(!intParamList_.Equals(other.intParamList_)) return false;
      if (EffectAlias != other.EffectAlias) return false;
      if(!floatParamList_.Equals(other.floatParamList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      hash ^= intParamList_.GetHashCode();
      if (EffectAlias.Length != 0) hash ^= EffectAlias.GetHashCode();
      hash ^= floatParamList_.GetHashCode();
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
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Type);
      }
      if (EffectAlias.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(EffectAlias);
      }
      intParamList_.WriteTo(output, _repeated_intParamList_codec);
      floatParamList_.WriteTo(output, _repeated_floatParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Type);
      }
      if (EffectAlias.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(EffectAlias);
      }
      intParamList_.WriteTo(ref output, _repeated_intParamList_codec);
      floatParamList_.WriteTo(ref output, _repeated_floatParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
      }
      size += intParamList_.CalculateSize(_repeated_intParamList_codec);
      if (EffectAlias.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EffectAlias);
      }
      size += floatParamList_.CalculateSize(_repeated_floatParamList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LuaEnvironmentEffectNotify other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      intParamList_.Add(other.intParamList_);
      if (other.EffectAlias.Length != 0) {
        EffectAlias = other.EffectAlias;
      }
      floatParamList_.Add(other.floatParamList_);
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
            Type = input.ReadUInt32();
            break;
          }
          case 26: {
            EffectAlias = input.ReadString();
            break;
          }
          case 98:
          case 96: {
            intParamList_.AddEntriesFrom(input, _repeated_intParamList_codec);
            break;
          }
          case 114:
          case 117: {
            floatParamList_.AddEntriesFrom(input, _repeated_floatParamList_codec);
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
            Type = input.ReadUInt32();
            break;
          }
          case 26: {
            EffectAlias = input.ReadString();
            break;
          }
          case 98:
          case 96: {
            intParamList_.AddEntriesFrom(ref input, _repeated_intParamList_codec);
            break;
          }
          case 114:
          case 117: {
            floatParamList_.AddEntriesFrom(ref input, _repeated_floatParamList_codec);
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